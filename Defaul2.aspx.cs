using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
using System.Text.RegularExpressions;
public partial class Defaul2 : System.Web.UI.Page
{
    // DataSet dt1;
    protected void Page_Load(object sender, EventArgs e)
    {
        //this.TextBox1.Focus(TextBox1.Text.Length);

        
        if (!IsPostBack)
        {
            //Response.Write(Session["height"].ToString());
            if (Request.Cookies["info"] == null)
                Response.Redirect("登陆页面.aspx");
            Label1.Text = Request.Cookies["info"].Values["nickname"].ToString();
            String strConnection = "Provider=Microsoft.Ace.OleDb.12.0; Data Source=" + Server.MapPath("data.mdb");
            OleDbConnection con = new OleDbConnection(strConnection);
            con.Open();
            char ch = Convert.ToChar(34);
            string order = "select count(关注的人) from focus where 用户昵称=" + ch + Request.Cookies["info"].Values["nickname"].ToString() + ch;
            OleDbCommand myCommand1 = new OleDbCommand(order, con);
            int count = (int)myCommand1.ExecuteScalar();

            Button8.Text = Convert.ToString(count);
            string order1 = "select count(用户昵称) from focus where 关注的人= " + ch + Request.Cookies["info"].Values["nickname"].ToString() + ch;

            OleDbCommand c2 = new OleDbCommand(order1, con);
            Button9.Text = Convert.ToString((int)c2.ExecuteScalar());

            string order2 = "select count(*) from [post] where 昵称= " + ch + Request.Cookies["info"].Values["nickname"].ToString() + ch;
            OleDbCommand myCommand3 = new OleDbCommand(order2, con);
            Button10.Text = Convert.ToString((int)myCommand3.ExecuteScalar());

            string order3 = "select 头像 from people where 昵称=" + ch + Request.Cookies["info"].Values["nickname"].ToString() + ch + ";";
            OleDbCommand myCommand4 = new OleDbCommand(order3, con);
            OleDbDataReader read1 = myCommand4.ExecuteReader();

            while (read1.Read())
            {
                look.ImageUrl = read1.GetString(0);
                look.ToolTip = Request.Cookies["info"].Values["nickname"].ToString();
            }
            con.Close();
        }
        else
        {
            // this.Panel1.Visible = false;
        }
    }
    public OleDbDataReader imgbind()
    {

        char ch = Convert.ToChar(34);
        string str = "select people.头像 from [people],[focus] where (focus.用户名=" + ch + Request.Cookies["info"].Values["user"].ToString() + ch + "and focus.关注的人=people.用户名;";
        //     string str = "select 头像 from [people] where 用户名=" + ch + Request.Cookies["info"].Values["user"].ToString() + ch;
        String strConnection = "Provider=Microsoft.Ace.OleDb.12.0; Data Source=" + Server.MapPath("data.mdb");
        OleDbConnection con = new OleDbConnection(strConnection);
        OleDbCommand c = new OleDbCommand(str, con);
        ;
        //  Label9.Text = str;
        con.Open();
        //  Label2.Text = "hello";
        return c.ExecuteReader();
    }
    public OleDbDataReader namebind()
    {
        char ch = Convert.ToChar(34);
        string str = "select people.昵称 from [people],[focus] where focus.用户名=" + ch + Request.Cookies["info"].Values["user"].ToString() + ch + "and focus.关注的人=people.用户名;";
        String strConnection = "Provider=Microsoft.Ace.OleDb.12.0; Data Source=" + Server.MapPath("data.mdb");
        OleDbConnection con = new OleDbConnection(strConnection);

        OleDbCommand c = new OleDbCommand(str, con);
        //  Label9.Text = str;
        con.Open();
        return c.ExecuteReader();
    }
    protected void ImageButton6_Click(object sender, ImageClickEventArgs e)
    {
        Panel1.Visible = false;
        if (TextBox1.Text.Length > 140||TextBox1.Text.Length==0)
        {
            return;
        }
        if (Request.Cookies["info"] != null)
        {
            String strConnection = "Provider=Microsoft.Ace.OleDb.12.0; Data Source=" + Server.MapPath("data.mdb");
            OleDbConnection con = new OleDbConnection(strConnection);
            con.Open();
            string order;
            char ch = Convert.ToChar(34);
            order = "insert into post(昵称,原创内容,时间,原创,最后修改时间,昨天转发总数,转发总数) values('";
            order += Convert.ToString(Label1.Text);
            order += "','";
            order += TextBox1.Text;
            order += "','";
            order += System.DateTime.Now.ToString();
            order += "',1,'";
            order += System.DateTime.Now;
            order += "',0,0)";

            OleDbCommand a1 = new OleDbCommand(order, con);
            a1.ExecuteNonQuery();
            con.Close();
        }
        TextBox1.Text = "";
        Response.Redirect("Defaul2.aspx");
    }

    protected void Button8_Click(object sender, EventArgs e)
    {
        Response.Redirect("关注的人.aspx");
    }
    protected void Button9_Click(object sender, EventArgs e)
    {
        Response.Redirect("我的粉丝.aspx");
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {

    }
    protected void ImageButton7_Click(object sender, ImageClickEventArgs e)
    {

        if (this.Panel1.Visible)
            this.Panel1.Visible = false;
        else
        {
            this.Panel1.Visible = true;
        }
        this.TextBox1.Focus();
    }
    protected void look_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("我的封面.aspx");
    }
    protected void Button4_Click(object sender, EventArgs e)
    {

    }
    protected void Button10_Click(object sender, EventArgs e)
    {
        Response.Redirect("我的封面.aspx");
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Defaul2.aspx");
    }
    protected void Button7_Click(object sender, EventArgs e)
    {
        Response.Write("<script>window.open('转发微博.aspx')</script>");
    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {

    }

    protected void Button11_Click(object sender, EventArgs e)
    {

    }
    protected void Button13_Click(object sender, EventArgs e)
    {

    }
    protected void ImageButton8_Click(object sender, ImageClickEventArgs e)
    {

    }
    protected void ImageButton9_Click(object sender, ImageClickEventArgs e)
    {

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        myweibocontent.Src = "收藏页面.aspx";
    }
    protected void Button6_Click(object sender, EventArgs e)
    {
    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {
        int count = TextBox1.Text.Length;
        if (count <= 140)
        {

            Label3.Text = "还能输入" + (140 - count) + "个字符";
        }
    }
    protected void ImageButton5_Click(object sender, ImageClickEventArgs e)
    {

    }
    protected void Button3_Click(object sender, EventArgs e)
    {

    }
    protected void Timer1_Tick(object sender, EventArgs e)
    {
        if (TextBox1.Text != "")
        {
            if (TextBox1.Text.Length > 140)
            {
                Label3.Text = "已超过" + (TextBox1.Text.Length - 140) + "个字";
                Label3.ForeColor = System.Drawing.Color.Red;
                //ImageButton6.Enabled = false;
                //ImageButton6.Attributes.Add("disabled", "true");
            }
            else
            {
                Label3.Text = "还能输入" + (140 - TextBox1.Text.Length) + "个字";
                Label3.ForeColor = System.Drawing.Color.Black;
                //  ImageButton6.Attributes.Add("disabled", "false");
            }
        }
        else
            Label3.Text = "";
    }
}