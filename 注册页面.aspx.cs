using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Data;

public partial class 注册页面 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        String strConnection = "Provider=Microsoft.Ace.OleDb.12.0; Data Source=" + Server.MapPath("data.mdb");
        OleDbConnection con = new OleDbConnection(strConnection);
        con.Open();
        //  string order
        string usrname, mailadd, pd;
        usrname = Convert.ToString(TextBox1.Text);
        mailadd = Convert.ToString(TextBox2.Text);
        pd = Convert.ToString(TextBox3.Text);
        string order1, order2, order3,order4;
        //  char ch = 34;
        char ch = Convert.ToChar(34);
        //  order = "insert into people(mail） values("+ch + usrname+ch + ", "+ch+mailadd+ch+");";
        //order = "insert into people(用户名,注册邮箱） values("+ch +usrname.ToString()+ch+","+ch+ mailadd.ToString() + ch + ");";
        order1 = "select * from people where 用户名=" + ch + usrname + ch;
        order3 = "select * from people where 注册邮箱=" + ch + mailadd + ch;
        order4 = "select * from manager where 管理员姓名='"+usrname+"'";
        OleDbDataAdapter myCommand1 = new OleDbDataAdapter(order1, con);

        DataSet ds = new DataSet();          //数据集合
        myCommand1.Fill(ds, "type");
        DataTable dt = new DataTable();        //数据表
        dt = ds.Tables["type"];

        OleDbDataAdapter myCommand2 = new OleDbDataAdapter(order3, con);
        DataSet ds1 = new DataSet();          //数据集合
        myCommand2.Fill(ds1, "type1");
        DataTable dt1 = new DataTable();        //数据表
        dt1 = ds1.Tables["type1"];

        OleDbDataAdapter mycmd3 = new OleDbDataAdapter(order4,con);
        DataSet ds2 = new DataSet();
        mycmd3.Fill(ds2,"type2");
        DataTable dt2 = new DataTable();
        dt2=ds2.Tables["type2"];

        Response.Write(order4+dt2.Rows.Count);
        if (dt.Rows.Count == 0 && dt1.Rows.Count == 0&&dt2.Rows.Count==0)
        {
            order2 = "insert into people(用户名,注册邮箱,密码,昵称,注册时间,头像) values(" + ch + usrname + ch + "," + ch + mailadd + ch + "," + ch + pd + ch + "," + ch + usrname + ch + "," + ch + System.DateTime.Now.ToString("yyyy-MM-dd") + ch + ",'~/image/默认.jpg'" + ");";
           order3 = "insert into visit(用户名,Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday,上周访问总数,本周访问总数,最后修改时间) values('"+usrname+"',0,0,0,0,0,0,0,0,0,'"+System.DateTime.Now+"')";
           OleDbCommand c1 = new OleDbCommand(order3,con);
           c1.ExecuteNonQuery();
            //Label5.Text = order2;
            OleDbCommand myCommand = new OleDbCommand(order2, con);
            myCommand.ExecuteNonQuery();
            con.Close();
            HttpCookie cookie = new HttpCookie("info");
            cookie.Expires = DateTime.Now.AddYears(1);
            cookie.Values.Add("user", usrname);
            cookie.Values.Add("nickname", usrname);
           // cookie.Values.Add("pd", pd);
            cookie.Values.Add("manager1", "no");
            // cookie.Values.Add("nowpos",usrname);
            Session["nowpos"] = usrname;
            Response.AppendCookie(cookie);
            Response.Redirect("Defaul2.aspx");
        }
        if (dt.Rows.Count != 0&&dt2.Rows.Count!=0)
        {
            Response.Write("<script>alert('用户名已经存在！" + Convert.ToString(dt.Rows.Count) + "');</script>");
            TextBox1.Text = "";
        }

        if (dt1.Rows.Count != 0)
        {
            Response.Write("<script>alert('邮箱已经被注册！" + Convert.ToString(dt1.Rows.Count) + "');</script>");
            TextBox2.Text = "";

        }
        con.Close();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("登陆页面.aspx");
    }
}