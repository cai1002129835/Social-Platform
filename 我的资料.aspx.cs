using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
public partial class 我的资料 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            nicknane.Visible = false;
            realname.Visible = false;
            // TextBox3.Visible = false;
            //   TextBox4.Visible = false;
            //   TextBox5.Visible = false;
            //   TextBox6.Visible = false;
            mywords.Visible = false;
            submit1.Visible = false;
            male.Visible = false;
            female.Visible = false;
            feeling.Visible = false;
            
            // TextBox1.Visible = false;
            if (Request.Cookies["info"] != null)
            {

                //  Label1.Text = Request.Cookies["info"].Values["user"].ToString();
                // char ch = Convert.ToChar(34);
                // String order = "select  用户名，昵称，真实姓名，所在地，性别，感情状况，生日，简介，注册时间 from people where 用户名=" + ch + Convert.ToString(Label1.Text) + ch + ";";
                // Label13.Text = order;
                // String dbname = Server.MapPath("data.mdb");
                String strConnection = "Provider=Microsoft.Ace.OleDb.12.0; Data Source=" + Server.MapPath("data.mdb");
                OleDbConnection con = new OleDbConnection(strConnection);
                con.Open();
                string order;
                char ch = Convert.ToChar(34);
                //   order = "select  用户名，昵称，真实姓名，所在地，性别，感情状况，生日，简介，注册时间 from people where 用户名=" + ch + Convert.ToString(Label1.Text) + ch + ";";
                order = "select  用户名,昵称,真实姓名,所在地,性别,感情状况,生日,简介,注册时间,qq,msn,mail from people where 昵称=" + ch + Session["nowpos"].ToString() + ch + ";";
                OleDbDataAdapter myCommand1 = new OleDbDataAdapter(order, con);
                //  Label13.Text = order;
                DataSet ds = new DataSet();          //数据集合
                myCommand1.Fill(ds, "type");
                DataTable dt = new DataTable();        //数据表
                dt = ds.Tables["type"];
                Label1.Text = dt.Rows[0][0].ToString();
                Label2.Text = dt.Rows[0][1].ToString();
                Label3.Text = dt.Rows[0][2].ToString();
                Label4.Text = dt.Rows[0][3].ToString();
                Label5.Text = dt.Rows[0][4].ToString();
                Label6.Text = dt.Rows[0][5].ToString();
                Label7.Text = dt.Rows[0][6].ToString();
                Label8.Text = dt.Rows[0][7].ToString();
                Label9.Text = dt.Rows[0][8].ToString();

                // year.Items.Add(new ListItem(System.DateTime.Now.Year.ToString()));
                //  month.Items.Add(new ListItem(System.DateTime.Now.Month.ToString()));
                // day.Items.Add(new ListItem(System.DateTime.Now.Day.ToString()));
                if (Request.Cookies["info"].Values["nickname"].ToString() != Session["nowpos"].ToString())
                {
                    Button1.Visible = false;
                    submit1.Visible = false;
                    Button4.Visible = false;
                }
                //Label10.Text = dt.Rows[0][8].ToString();
                con.Close();
            }
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        mywords.Text = Label8.Text;
        nicknane.Text = Label2.Text;
        realname.Text = Label3.Text;
        Label2.Visible = false;
        Label3.Visible = false;
        Label4.Visible = false;
        Label5.Visible = false;
        Label6.Visible = false;
        Label7.Visible = false;
        Label8.Visible = false;
        Button1.Visible = false;
        // Label9.Visible = false;
        nicknane.Visible = true;
        realname.Visible = true;
        // TextBox3.Visible = true;
        //  TextBox4.Visible = true;
        //   TextBox5.Visible = true;
        //  TextBox6.Visible = true;
        mywords.Visible = true;

        submit1.Visible = true;

        male.Visible = true;
        female.Visible = true;
        feeling.Visible = true;

        String strConnection = "Provider=Microsoft.Ace.OleDb.12.0; Data Source=" + Server.MapPath("data.mdb");
        OleDbConnection con = new OleDbConnection(strConnection);
        con.Open();
        string order;
        char ch = Convert.ToChar(34);
        //   order = "select  用户名，昵称，真实姓名，所在地，性别，感情状况，生日，简介，注册时间 from people where 用户名=" + ch + Convert.ToString(Label1.Text) + ch + ";";
        order = "select  所在地,性别,感情状况,生日 from people where 用户名=" + ch + Convert.ToString(Label1.Text) + ch + ";";
        OleDbDataAdapter myCommand1 = new OleDbDataAdapter(order, con);
        //  Label13.Text = order;
        DataSet ds = new DataSet();          //数据集合
        myCommand1.Fill(ds, "type");
        DataTable dt = new DataTable();        //数据表
        dt = ds.Tables["type"];
        if (dt.Rows[0][1].ToString() == "女")
            female.Checked = true;
        else
            male.Checked = true;

        if (!dt.Rows[0][2].ToString().Equals(""))
        {
            feeling.ClearSelection();
            feeling.Items.FindByText(dt.Rows[0][2].ToString()).Selected = true;
        }
        con.Close();
        year.Visible = true;
        month.Visible = true;
        day.Visible = true;



        string[] birth = dt.Rows[0][3].ToString().Split('-');
        year.Items.Clear();
        year.Items.Add(new ListItem("请选择"));
        for (int i = 1900; i <= Convert.ToInt16(System.DateTime.Now.Year.ToString()); i++)
        {
            string str = Convert.ToString(i);
            year.Items.Add(new ListItem(str));
        }
        if (birth.Length != 1)
        {
            // year.Items.Add(new ListItem(birth[0]));
            year.SelectedValue = birth[0];
            month.Items.Add(new ListItem(birth[1]));
            day.Items.Add(new ListItem(birth[2]));
        }
        else
        {

            month.Items.Add(new ListItem("请选择"));
            day.Items.Add(new ListItem("请选择"));
        }

    }
    protected void Button4_Click(object sender, EventArgs e)
    {
       
        day.Visible = false;
        month.Visible = false;
        year.Visible = false;
        string birth;
        birth = year.SelectedValue;
        birth += "-";
        birth += month.SelectedValue;
        birth += "-";
        birth += day.SelectedValue;
        string order;
        order = "update people set ";
        char ch = Convert.ToChar(34);
        //    if (Convert.ToString(nicknane.Text) != "")
        {

            order += "昵称=";
            order += ch;
            order += Convert.ToString(nicknane.Text);
            order += ch;
            order += ",";
            Request.Cookies["info"].Values["nickname"] = Convert.ToString(nicknane.Text);
        }
        //   if (Convert.ToString(realname.Text) != "")
        {

            order += "真实姓名=";
            order += ch;
            order += Convert.ToString(realname.Text);
            order += ch;
            order += ",";
        }
        if (male.Checked)
        {
            order += "性别=";
            order += ch;
            order += Convert.ToString("男");
            order += ch;
            order += ",";
        }
        else
        {

            order += "性别=";
            order += ch;
            order += Convert.ToString("女");
            order += ch;
            order += ",";
        }
        //if(feeling.SelectedItem.Text)
        order += "感情状况=";
        order += ch;
        order += Convert.ToString(feeling.SelectedItem.Text);
        order += ch;
        order += ",";

        order += "简介=";
        order += ch;
        order += Convert.ToString(mywords.Text);
        order += ch;
        order += ",生日='";
        order += birth;
        order += "' where 用户名=";
        order += ch;
        order += Convert.ToString(Label1.Text);
        order += ch;
        order += ";";
        //  Label13.Text = order;
        //   OleDbConnection myConnection = new OleDbConnection(“Provider=Microsoft.Jet.OLEDB.4.0;Data Source=数据库源"); 
        String strConnection = "Provider=Microsoft.Ace.OleDb.12.0; Data Source=" + Server.MapPath("data.mdb");
        OleDbConnection con = new OleDbConnection(strConnection);
        con.Open();
        OleDbCommand myCommand = new OleDbCommand(order, con);
        myCommand.ExecuteNonQuery();



        nicknane.Visible = false;
        realname.Visible = false;
        // TextBox3.Visible = false;
        //  TextBox4.Visible = false;
        //   TextBox5.Visible = false;
        //  TextBox6.Visible = false;
        feeling.Visible = false;
        mywords.Visible = false;

        male.Visible = false;
        female.Visible = false;

       

        Label3.Text = realname.Text;
        if (male.Checked)
            Label5.Text = "男";
        else
            Label5.Text = "女";
        Label8.Text = mywords.Text;
        Label6.Text = feeling.SelectedItem.Text;
        Label2.Visible = true;
        Label3.Visible = true;
        Label4.Visible = true;
        Label5.Visible = true;
        Label6.Visible = true;
        Label7.Visible = true;
        Label8.Visible = true;
        Button1.Visible = true;
        submit1.Visible = false;
        //   Request.Cookies["info"].Values["nickname"]=nicknane.Text;
       // if (Request.Cookies["info"].Values["nickname"].ToString() != nicknane.Text)
        {

            string []updatestr = new string[30];

            updatestr [0]= "update [post] set 昵称='" + nicknane.Text + "' where 昵称='" + Label2.Text + "';";
            updatestr[1] = "update [post] set 原创昵称='" + nicknane.Text + "' where 原创昵称='" + Label2.Text + "';";
            updatestr[2] = "update [reportpeople] set 举报人='" + nicknane.Text + "' where 举报人='" + Label2.Text + "';";
            updatestr[3] = "update [reportpeople] set 举报用户='" + nicknane.Text + "' where 举报用户='" + Label2.Text + "';";
            updatestr[4] = "update [blacklist] set 用户昵称='" + nicknane.Text + "' where 用户昵称='" + Label2.Text + "';";
            updatestr[5] = "update [comment] set 昵称='" + nicknane.Text + "' where 昵称='" + Label2.Text + "';";
            updatestr[6] = "update [comment] set 微博用户='" + nicknane.Text + "' where 微博用户='" + Label2.Text + "';";
            updatestr[7] = "update [focus] set 用户昵称='" + nicknane.Text + "' where 用户昵称='" + Label2.Text + "';";
            updatestr[8] = "update [focus] set 关注的人='" + nicknane.Text + "' where 关注的人='" + Label2.Text + "';";
            updatestr[9] = "update [reportview] set 举报人='" + nicknane.Text + "' where 举报人='" + Label2.Text + "';";
            updatestr[10] = "update [reportview] set 举报用户='" + nicknane.Text + "' where 举报用户='" + Label2.Text + "';";
            updatestr[11] = "update [reportweibo] set 举报人='" + nicknane.Text + "' where 举报人='" + Label2.Text + "';";
            updatestr[12] = "update [reportweibo] set 举报用户='" + nicknane.Text + "' where 举报用户='" + Label2.Text + "';";
            updatestr[13] = "update [reserve] set 用户昵称='" + nicknane.Text + "' where 用户昵称='" + Label2.Text + "';";
            updatestr[14] = "update [reserve] set 微博用户='" + nicknane.Text + "' where 微博用户='" + Label2.Text + "'";
            updatestr[15] = "update [comment] set 微博内容=replace(微博内容,'" + "@" + Label2.Text + "','" + "@" + nicknane.Text + "') where 微博内容 is not null";
            updatestr[16] = "update [post] set 转发内容=replace(转发内容,'" + "@" + Label2.Text + " ','" + "@" + nicknane.Text + " ') where 转发内容 is not null";
            updatestr[17] = "update [post] set 原创内容=replace(原创内容,'" + "@" + Label2.Text + " ','" + "@" + nicknane.Text + " ') where 原创内容 is not null";
            updatestr[18] = "update [reportweibo] set 举报微博=replace(举报微博,'" + "@" + Label2.Text + " ','" + "@" + nicknane.Text + " ') where 举报微博 is not null";
            updatestr[19] = "update [reserve] set 收藏的微博=replace(收藏的微博,'" + "@" + Label2.Text + " ','" + "@" + nicknane.Text + " ') where 收藏的微博 is not null";
            OleDbCommand updateo = new OleDbCommand(updatestr[0],con);
            updateo.ExecuteNonQuery();
           ///updateo.Connection = con;
         //   OleDbTransaction ts = con.BeginTransaction();
          // Response.Write("<script>alert(haah'"+updatestr[1]+"')</script>");
          //  updateo.Transaction = ts;
            for (int i = 1; i < 20; i++)
            {
                updateo.CommandText = updatestr[i];
                updateo.Connection = con;
               updateo.ExecuteNonQuery();
               Response.Write(updatestr[i]+"</br>");
            }
           // ts.Commit();
                //  updateo.
            Label2.Text = nicknane.Text;
                Response.Cookies["info"].Values.Set("user", Request.Cookies["info"].Values["user"].ToString());
          //  Response.Cookies["info"].Values.Set("pd", Request.Cookies["info"].Values["pd"].ToString());
            Response.Cookies["info"].Values.Set("manager1", Request.Cookies["info"].Values["manager1"].ToString());

            Response.Cookies["info"].Values.Set("nickname", Convert.ToString(nicknane.Text));
            // Response.Cookies["info"].Values.Set("nowpos", Convert.ToString(nicknane.Text));
            Session["nowpos"] = Convert.ToString(nicknane.Text);
            // Response.Cookies["info"].Values.Set("user", Request.Cookies["info"].Values["user"].ToString());
            //  Response.Cookies["info"].Values.Set("pd", Request.Cookies["info"].Values["pd"].ToString());
        }
        con.Close();
        Response.Redirect("我的资料.aspx");
    }
    protected void realname_TextChanged(object sender, EventArgs e)
    {

    }
    protected void Button5_Click(object sender, EventArgs e)
    {

    }
    protected void Button2_Click(object sender, EventArgs e)
    {

    }
    protected void year_SelectedIndexChanged(object sender, EventArgs e)
    {

        month.Items.Clear();

        for (int i = 1; i <= 12; i++)
        {
            string str = Convert.ToString(i);
            month.Items.Add(new ListItem(str));
        }
    }
    protected void month_SelectedIndexChanged(object sender, EventArgs e)
    {
        day.Items.Clear();

        for (int i = 1; i <= System.DateTime.DaysInMonth(Convert.ToInt16(year.SelectedValue.ToString()), Convert.ToInt16(month.SelectedValue.ToString())); i++)
        {
            string str = Convert.ToString(i);
            day.Items.Add(new ListItem(str));

        }
    }
    protected void day_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void Button4_Click1(object sender, EventArgs e)
    {
        Response.Write("<script>window.showModelessDialog('修改密码.aspx',window,'dialogHeight:350px;dialogWidth:600px;help:0;center:yes;resizable:0;status:0;scroll:no')</script>");
    }
}