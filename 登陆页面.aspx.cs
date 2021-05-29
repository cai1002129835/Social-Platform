using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
using System.Xml;
using System.IO;
public partial class 登陆页面 : System.Web.UI.Page
{
   
    protected void Page_Load(object sender, EventArgs e)
    {
       
        if (!IsPostBack)
        {
            Label1.Visible = false;
            Label2.Visible = false;

            //验证cookie
            if (Request.Cookies["info"] != null)
            {
                if (Request.Cookies["info"].Values["manager1"].ToString() == "no")
                    Response.Redirect("Defaul2.aspx");
                else
                    Response.Redirect("管理员管理页.aspx");
            }
            adbind();
            //adinfo.Text=this.ad1.
           
        }
       //
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (String.Compare(Request.Cookies["yzmcode"].Value, TextBox3.Text, true) != 0)
        {
            Response.Write("<script>alert('验证码错误!')</script>");
            return;
        }
       
        String dbname = Server.MapPath("data.mdb");
        String strConnection = "Provider=Microsoft.Ace.OleDb.12.0; Data Source=" + Server.MapPath("data.mdb");
        OleDbConnection con = new OleDbConnection(strConnection);
        con.Open();
        string order;
        string input = Convert.ToString(TextBox1.Text);

        if (input.Contains("@"))//输入的是邮箱
        {
            char ch = Convert.ToChar(34);
            order = "select 密码,昵称,封号,昵称 from people where 注册邮箱=" + ch + input + ch + ";";

        }
        else
        {
            char ch = Convert.ToChar(34);
            order = "select 密码,昵称,封号,昵称 from people where 用户名=" + ch + input + ch + ";";

        }

        ////在数据库中查找
        OleDbDataAdapter myCommand1 = new OleDbDataAdapter(order, con);
        DataSet ds = new DataSet();          //数据集合

        myCommand1.Fill(ds, "type");
        DataTable dt = new DataTable();        //数据表
        dt = ds.Tables["type"];

        if (dt.Rows.Count != 0)
        {
            if (dt.Rows[0][0].ToString() != Convert.ToString(TextBox2.Text))
            {
                Label2.Text = "密码输入有误";
                Label2.Visible = true;
                TextBox2.Text = "";
              //  return;
            }
            else
            {
                ///还要检查是不是在黑名单中
                bool flag = false;
                if (dt.Rows[0][2].ToString() == "0")
                    flag = true;
                else
                {

                    string s = "select 处罚结束时间 from blacklist where 用户昵称='" + dt.Rows[0][3].ToString() + "'";
                    OleDbCommand s1 = new OleDbCommand(s, con);
                    OleDbDataReader r = s1.ExecuteReader();
                    while (r.Read())
                    {
                        if (r.GetDateTime(0) != System.DateTime.MaxValue)
                        {
                            if (r.GetDateTime(0) < System.DateTime.Now)
                                flag = true;
                        }
                    }
                    if (flag)
                    {
                        s = "delete from blacklist where 用户昵称='" + dt.Rows[0][3].ToString() + "'";
                        string s2 = "update people set 封号=0 where 昵称='" + dt.Rows[0][3].ToString() + "'";
                        OleDbCommand s3 = new OleDbCommand(s, con);
                        s3.ExecuteNonQuery();
                        OleDbCommand s4 = new OleDbCommand(s2, con);
                        s4.ExecuteNonQuery();

                    }

                }
                if (flag)
                {
                    HttpCookie cookie = new HttpCookie("info");
                    cookie.Expires = DateTime.Now.AddYears(1);
                    cookie.Values.Add("user", Convert.ToString(TextBox1.Text));
                   // cookie.Values.Add("pd", Convert.ToString(TextBox2.Text));
                    cookie.Values.Add("nickname", dt.Rows[0][1].ToString());
                    cookie.Values.Add("manager1", "no");
                     cookie.Values.Add("nowpos", dt.Rows[0][1].ToString());
                    Session["nowpos"] = dt.Rows[0][1].ToString();
                    Response.AppendCookie(cookie);
                    con.Close();
                    Response.Redirect("Defaul2.aspx");
                }
                else
                {
                    Response.Write("<script languge='javascript'> alert('您已经被封号，不允许进入微博') </script>");
                }
            }
        }
        else
        {
            if (input.Contains("@"))
            {
                Label1.Text = "此邮箱尚未注册";
                Label1.Visible = true;
                TextBox1.Text = "";
                TextBox2.Text = "";
                // RequiredFieldValidator1.Init();
            }
            else
            {
                ///检查是不是管理员
                ///
                bool flag = true;
                order = "select 管理员姓名,密码 from manager where 管理员姓名='" + TextBox1.Text + "'";
                OleDbCommand managercheck = new OleDbCommand(order, con);
                OleDbDataReader r = managercheck.ExecuteReader();
                while (r.Read())
                {
                    flag = false;
                    if (r.GetString(1) == TextBox2.Text)
                    {

                        HttpCookie cookie = new HttpCookie("info");
                        cookie.Expires = DateTime.Now.AddYears(1);
                        cookie.Values.Add("user", Convert.ToString(TextBox1.Text));
                        cookie.Values.Add("pd", Convert.ToString(TextBox2.Text));
                        cookie.Values.Add("nickname", Convert.ToString(TextBox1.Text));
                        cookie.Values.Add("manager1", "yes");
                        // cookie.Values.Add("nowpos", dt.Rows[0][1].ToString());
                        Session["nowpos"] = TextBox1.Text;
                        Response.AppendCookie(cookie);
                        con.Close();
                        Response.Redirect("管理员管理页.aspx");
                    }
                    else
                    {
                        Label2.Text = "密码输入有误";
                        Label2.Visible = true;
                    }
                }
                if (flag)
                {
                    Label1.Text = "此用户名尚未注册";
                    Label1.Visible = true;
                    TextBox1.Text = "";
                    TextBox2.Text = "";
                }
            }
        }
        con.Close();
    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        // RequiredFieldValidator1.Enabled = false;

        Response.Redirect("注册页面.aspx");
    }
    public void adbind()
    {
        String dbname = Server.MapPath("data.mdb");
        String strConnection = "Provider=Microsoft.Ace.OleDb.12.0; Data Source=" + Server.MapPath("data.mdb");
        OleDbConnection con = new OleDbConnection(strConnection);
        con.Open();
        // string order = "select 名称,图片,链接 from advertisement where 开始时间>=now() and now()<=结束时间";
        string order = "select 描述信息 as AlternateText,图片 as ImageUrl,链接 as NavigateUrl from advertisement where 开始时间<=now() and now()<=结束时间 ";
        OleDbDataAdapter d = new OleDbDataAdapter(order, con);
        DataSet ds = new DataSet();
        d.Fill(ds, "type");
        con.Close();
        ds.WriteXml(Server.MapPath("ad.xml"));
        //
        //    FileInfo fi = new FileInfo(Server.MapPath("ad.xml"));
        // Response.Write(Server.MapPath("ad.xml"));
        StreamReader sr = File.OpenText(Server.MapPath("ad.xml"));

        string str = "";
        while (sr.Peek() != -1)
            str += sr.ReadLine();
        sr.Close();
        // Response.Write(str);
        str = str.Replace("<NewDataSet>", "<Advertisements>");
        str = str.Replace("</NewDataSet>", "</Advertisements>");
        str = str.Replace("<type>", "<Ad>");
        str = str.Replace("</type>", "</Ad>");

        // Response.Write(str);
        StreamWriter f = new StreamWriter(Server.MapPath("ad.xml"));
        f.Write(str);
        f.Close();
        // Label3.Text = str;
    }
    protected void AdRotator1_AdCreated(object sender, AdCreatedEventArgs e)
    {
    }
    protected void Unnamed2_Tick(object sender, EventArgs e)
    {
        adbind();

    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
    protected void ChangeCode_Click(object sender, EventArgs e)
    {

    }
}