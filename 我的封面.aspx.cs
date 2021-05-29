using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
public partial class 我的封面 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // ListBox1.Style = "dispaly:none";
        //Panel1.Style = "dispaly:none";
        //Label1.Text = Request.Cookies["info"].Values["nickname"].ToString();
        // Panel1.Visible = false;
        if (Request.Cookies["info"] == null)
            Response.Redirect("登陆页面.aspx");
        //   Response.Write(Request.Cookies["info"].Value);
        if (Session["nowpos"] != null)
            name.Text = Session["nowpos"].ToString();
        else
        {
            Session["nowpos"] = Request.Cookies["info"].Values["nickname"].ToString();
            name.Text = Session["nowpos"].ToString();
        }
        String strConnection = "Provider=Microsoft.Ace.OleDb.12.0; Data Source=" + Server.MapPath("data.mdb");
        OleDbConnection con = new OleDbConnection(strConnection);
        con.Open();
        if (!IsPostBack)
        {
            if (Session["nowpos"].ToString() != Request.Cookies["info"].Values["nickname"].ToString())
            {
                Button5.Visible = false;
                string addvisit = "";
                string preorder = "select  visit.最后修改时间,people.用户名 from visit,people where people.昵称='" + Session["nowpos"].ToString() + "' and  people.用户名=visit.用户名";
                OleDbCommand pre = new OleDbCommand(preorder, con);
                OleDbDataReader a = pre.ExecuteReader();
                while (a.Read())
                {
                    if ((System.DateTime.Now.Year - a.GetDateTime(0).Year > 0) || System.DateTime.Now.DayOfYear - a.GetDateTime(0).DayOfYear > 0)
                    {
                        addvisit = "update visit set 上周访问总数=本周访问总数,本周访问总数=本周访问总数+1-" + System.DateTime.Now.DayOfWeek.ToString() + "," + System.DateTime.Now.DayOfWeek.ToString() + "=1,最后修改时间='" + System.DateTime.Now + "' where 用户名='" + a.GetString(1) + "'";
                    }
                    else
                    {
                        //Response.Write(System.DateTime.Now.DayOfYear + " " + a.GetDateTime(0).DayOfYear+" "+Session["nowpos"]);
                        addvisit = "update visit set 本周访问总数=本周访问总数+1 ," + System.DateTime.Now.DayOfWeek.ToString() + "=" + System.DateTime.Now.DayOfWeek.ToString() + "+1,最后修改时间='" + System.DateTime.Now + "' where 用户名='" + a.GetString(1) + "'";
                    }

                }
                OleDbCommand updatevisit = new OleDbCommand(addvisit, con);
                updatevisit.ExecuteNonQuery();
            }
        }
        string order = "select 简介,头像,个人封面 from people where 昵称=";
        char ch = Convert.ToChar(34);
        order += ch;
        order += Convert.ToString(name.Text);
        order += ch;

        OleDbDataAdapter myCommand1 = new OleDbDataAdapter(order, con);
        DataSet ds = new DataSet();          //数据集合
        myCommand1.Fill(ds, "type");
        DataTable dt = new DataTable();        //数据表
        dt = ds.Tables["type"];

        if (dt.Rows.Count != 0)
            word.Text = dt.Rows[0][0].ToString();
        else
            word.Visible = false;
       // Response.Write(dt.Rows[0][2].ToString());
        if (dt.Rows[0][2].ToString() != "")
            // showbg.Attributes.Add("style","backgound-image:url('"+dt.Rows[0][2].ToString()+"')");
            Panel2.BackImageUrl = dt.Rows[0][2].ToString();
        else
           Panel2.BackImageUrl = "~/background/1.jpg";
            //Panel2.BackImageUrl = dt.Rows[0][2].ToString();
            //showbg.Style.Add("background-image", dt.Rows[0][2].ToString());
          //  showbg.Attributes.Add("background-image", dt.Rows[0][2].ToString());
        //    showbg.Attributes.Add("border", "1"); 
           // showbg.Attributes.Add("style", "background-image: url('"+dt.Rows[0][2].ToString()+"')");
        Image1.ImageUrl = dt.Rows[0][1].ToString();
        
        string porder = "select count(关注的人) from focus where 用户昵称=" + ch + Session["nowpos"].ToString() + ch;
        OleDbCommand pmyCommand1 = new OleDbCommand(porder, con);
        int count = (int)pmyCommand1.ExecuteScalar();

        Button8.Text = Convert.ToString(count);
        string order1 = "select count(用户昵称) from focus where 关注的人= " + ch + Session["nowpos"].ToString() + ch;

        OleDbCommand c2 = new OleDbCommand(order1, con);
        Button9.Text = Convert.ToString((int)c2.ExecuteScalar());

        string order2 = "select count(*) from post where 昵称= " + ch + Session["nowpos"].ToString() + ch;
        OleDbCommand myCommand3 = new OleDbCommand(order2, con);
        Button10.Text = Convert.ToString((int)myCommand3.ExecuteScalar());

        if (Request.Cookies["info"].Values["nickname"].ToString() != Session["nowpos"].ToString())
        {
            Button5.Visible = false;
            LinkButton1.Visible = false;
            LinkButton2.Visible = true;

            plus.Visible = true;
            string plusorder = "select count(*) from [focus] where 关注的人='" + Session["nowpos"].ToString() + "' and 用户昵称='" + Request.Cookies["info"].Values["nickname"].ToString() + "'";
            OleDbCommand o = new OleDbCommand(plusorder, con);
            if ((int)o.ExecuteScalar() != 0)
            {
                plus.Text = "已关注";
                Panel1.Visible = true;
                Panel1.Attributes.Add("style", "display:none");
              
            }
            else
            {
                plus.Text = "+关注";
                Panel1.Visible = true;
                Panel1.Attributes.Add("style", "display:none");
                Button11.Attributes.Add("style", "display:none");
                //Button14.Attributes.Add("style", "display:none");
            }
        }
        mainshow.Src = "微博页面.aspx";
        con.Close();
        if (Session["nowpos"].ToString() != Request.Cookies["info"].Values["nickname"].ToString())
        {

            showchart.Visible = false;
            showchart.Attributes.Add("style", "diaplay:none");
        }
    }
    public void drawchart(DataTable dt)///绘制图表
    {

        visit.DataSource = dt;
        visit.Series[0].XValueMember = "time";
        visit.Series[0].YValueMembers = "count";

        // visit.Series[0].XValueMember=
    }
    public DataTable createtable()////获得主页访问的数据
    {
        DataTable dt = new DataTable();
        dt.Columns.Add("time", System.Type.GetType("System.String"));
        dt.Columns.Add("count", System.Type.GetType("System.Int16"));
        string[] n = new string[] { "Monday", "Thuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        String strConnection = "Provider=Microsoft.Ace.OleDb.12.0; Data Source=" + Server.MapPath("data.mdb");
        OleDbConnection con = new OleDbConnection(strConnection);
        con.Open();
        string getdata = "select Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday,本周访问总数,上周访问总数 from visit where 用户名='" + Request.Cookies["info"].Values["user"].ToString() + "'";
        OleDbDataAdapter a = new OleDbDataAdapter(getdata, con);
        DataSet ds = new DataSet();
        a.Fill(ds, "type");
        DataTable dt1 = ds.Tables["type"];
        string[] m = new string[7];

        for (int i = 0; i < 7; i++)
        {
            DataRow dr = dt.NewRow();
            dr["time"] = n[i];
            dr["count"] = dt1.Rows[0][i];
            dt.Rows.Add(dr);
        }
        visitcount.Text = dt1.Rows[0][7].ToString();
        if (Convert.ToInt16(dt1.Rows[0][7]) > Convert.ToInt16(dt1.Rows[0][8]))
        {
            tend.ImageUrl = "~/photo/访问量增加.jpg";
        }
        else
        {

            tend.ImageUrl = "~/photo/访问量降低.jpg";
        }
        return dt;
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        bg.Visible = true;
        bg.Style.Add("display", "block");
        pre.Visible = false;
        one.ImageUrl = "~/background/1.jpg";
        two.ImageUrl = "~/background/2.jpg";
        three.ImageUrl = "~/background/3.jpg";
        four.ImageUrl = "~/background/4.jpg";
        Session["pageindex"] = 0;
        Session["oribg"] = Panel2.BackImageUrl;
    }
    protected void Button8_Click(object sender, EventArgs e)
    {
        Response.Redirect("关注的人.aspx");
    }
    protected void Button9_Click(object sender, EventArgs e)
    {
        Response.Redirect("我的粉丝.aspx");
    }
    protected void Image1_Click(object sender, ImageClickEventArgs e)
    {
        //Response.Redirect("头像设置.aspx");
        // Response.
        //  Image1.Attributes.Add("onclick", "return confirm('ok')");
        // Image1.Attributes.Add("onclick", "window.open('头像设置.aspx','_blank');return false");
        //  Response.Write("<script>window.showModelessDialog('头像设置.aspx')</script>");
        if(Session["nowpos"].ToString()==Request.Cookies["info"].Values["nickname"].ToString())
        mainshow.Src = "头像设置.aspx";
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        //Response.Redirect("我的资料.aspx");
        mainshow.Src = "我的资料.aspx";
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        mainshow.Src = "我的资料.aspx";
    }

    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {


    }
    protected void Button11_Click(object sender, EventArgs e)
    {
        string deletefocus = "delete from [focus] where 关注的人='" + Session["nowpos"].ToString() + "' and 用户昵称='" + Request.Cookies["info"].Values["nickname"].ToString() + "'";
        String strConnection = "Provider=Microsoft.Ace.OleDb.12.0; Data Source=" + Server.MapPath("data.mdb");

        OleDbConnection con = new OleDbConnection(strConnection);
        con.Open();
        OleDbCommand o = new OleDbCommand(deletefocus, con);
        o.ExecuteNonQuery();
        con.Close();
        Response.Redirect("我的封面");
        // Response.Write("<script>location.reload(true);</script>");
    }
    protected void Button12_Click(object sender, EventArgs e)////向管理员举报
    {
        Session["举报"] = "举报用户";
        Session["头像"] = Image1.ImageUrl;
        Session["简介"] = word.Text;
        Response.Write("<script>window.showModelessDialog('举报页面.aspx',window,'dialogHeight:350px;dialogWidth:600px;help:0;resizable:0;status:0;scroll:no')</script>");
    }
    protected void plus_Click(object sender, EventArgs e)
    {
        if (plus.Text == "+关注")
        {
            string addord = "insert into [focus](关注的人,关注时间,用户昵称) values('" + Session["nowpos"].ToString() + "','" + System.DateTime.Now.ToString() + "','" + Request.Cookies["info"].Values["nickname"].ToString() + "')";
            String strConnection = "Provider=Microsoft.Ace.OleDb.12.0; Data Source=" + Server.MapPath("data.mdb");

            OleDbConnection con = new OleDbConnection(strConnection);
            con.Open();
            OleDbCommand o = new OleDbCommand(addord, con);
            o.ExecuteNonQuery();
            con.Close();
            Response.Redirect("我的封面");
        }
    }
    protected void Button16_Click(object sender, EventArgs e)
    {

    }
    protected void visit_Load(object sender, EventArgs e)
    {
        drawchart(createtable());
    }
    protected void Button17_Click(object sender, EventArgs e)
    {
        bg.Visible = false;
        bg.Style.Add("display", "none");
        Response.Redirect("我的封面.aspx");
    }
    protected void Button18_Click(object sender, EventArgs e)
    {
        string order = "";
        if (Session["bg"] == null)
        {
            order = "update people set 个人封面='" + one.ImageUrl + "'  where 昵称='" + Request.Cookies["info"].Values["nickname"].ToString() + "'";
        }
        else
            order = "update people set 个人封面='" + Session["bg"].ToString() + "'  where 昵称='" + Request.Cookies["info"].Values["nickname"].ToString() + "'";
        String strConnection = "Provider=Microsoft.Ace.OleDb.12.0; Data Source=" + Server.MapPath("data.mdb");

        OleDbConnection con = new OleDbConnection(strConnection);
        con.Open();
        OleDbCommand o = new OleDbCommand(order, con);
        o.ExecuteNonQuery();
        con.Close();
        bg.Visible = false;
        bg.Style.Add("display", "none");
        // Response.Write(order);
        Response.Redirect("我的封面.aspx");
    }
    protected void Button16_Click1(object sender, EventArgs e)
    {
        int n = Convert.ToInt16(Session["pageindex"].ToString()) - 1;
        Session["pageindex"] = n;
        one.ImageUrl = "~/background/" + (n * 4 + 1) + ".jpg";
        two.ImageUrl = "~/background/" + (n * 4 + 2) + ".jpg";
        three.ImageUrl = "~/background/" + (n * 4 + 3) + ".jpg";
        four.ImageUrl = "~/background/" + (n * 4 + 4) + ".jpg";

        if (n == 0)
            pre.Visible = false;
        else
            pre.Visible = true;
        if (n == 4)
            next.Visible = false;
        else
            next.Visible = true;

    }
    protected void next_Click(object sender, EventArgs e)
    {
        int n = Convert.ToInt16(Session["pageindex"].ToString()) + 1;
        Session["pageindex"] = n;
        one.ImageUrl = "~/background/" + (n * 4 + 1) + ".jpg";
        two.ImageUrl = "~/background/" + (n * 4 + 2) + ".jpg";
        three.ImageUrl = "~/background/" + (n * 4 + 3) + ".jpg";
        four.ImageUrl = "~/background/" + (n * 4 + 4) + ".jpg";

        if (n == 4)
            next.Visible = false;
        else
            next.Visible = true;
        if (n == 0)
            pre.Visible = false;
        else
            pre.Visible = true;
        //Response.Write(one.ImageUrl);

    }
    protected void one_Click(object sender, ImageClickEventArgs e)
    {
        Session["bg"] = one.ImageUrl;
        one.BorderColor = System.Drawing.Color.Red;
        two.BorderColor = System.Drawing.Color.White;
        three.BorderColor = System.Drawing.Color.White;
        four.BorderColor = System.Drawing.Color.White;
        Panel2.BackImageUrl = one.ImageUrl;
      //  one.Style.Add("borderstyle","solid");
       // one.BackColor = System.Drawing.Color.White;
        //one.Style.Add("borderstyle","Solid");
       // one.Style.Add("borderColor","black");
      //  Response.Write("hah");
    }
    protected void two_Click(object sender, ImageClickEventArgs e)
    {
        Session["bg"] = two.ImageUrl;
        two.BorderColor = System.Drawing.Color.Red;
        one.BorderColor = System.Drawing.Color.White;
        three.BorderColor = System.Drawing.Color.White;
        four.BorderColor = System.Drawing.Color.White;
        Panel2.BackImageUrl = two.ImageUrl;
    }
    protected void three_Click(object sender, ImageClickEventArgs e)
    {
        Session["bg"] = three.ImageUrl;
        three.BorderColor = System.Drawing.Color.Red;
        two.BorderColor = System.Drawing.Color.White;
        one.BorderColor = System.Drawing.Color.White;
        four.BorderColor = System.Drawing.Color.White;
        Panel2.BackImageUrl = three.ImageUrl;
    }
    protected void four_Click(object sender, ImageClickEventArgs e)
    {
        Session["bg"] = four.ImageUrl;
        four.BorderColor = System.Drawing.Color.Red;
        two.BorderColor = System.Drawing.Color.White;
        three.BorderColor = System.Drawing.Color.White;
        one.BorderColor = System.Drawing.Color.White;
        Panel2.BackImageUrl = four.ImageUrl;
    }
    protected void Button19_Click(object sender, EventArgs e)
    {
        Panel2.BackImageUrl = Session["oribg"].ToString();
        bg.Style.Add("display", "none");
    }
}