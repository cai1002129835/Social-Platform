using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
public partial class 修改密码 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
        }
    }
    protected void Timer1_Tick(object sender, EventArgs e)
    {
        Panel2.Visible = false;
        this.Response.Write("<script language=javascript>window.close();</script>");

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        String strConnection = "Provider=Microsoft.Ace.OleDb.12.0; Data Source=" + Server.MapPath("data.mdb");
        OleDbConnection con = new OleDbConnection(strConnection);
        con.Open();
        string order = "";
        if (Request.Cookies["info"].Values["manager1"].ToString() == "no")
        {
            order = "select 密码 from people where 昵称='" + Request.Cookies["info"].Values["nickname"].ToString()+ "'";
        }
        else
        {
            order = "select 密码 from manager where 管理员姓名='" + Request.Cookies["info"].Values["nickname"].ToString() + "'";
        }
        OleDbCommand o = new OleDbCommand(order, con);
        OleDbDataReader r = o.ExecuteReader();
        bool flag = true;
        while (r.Read())
        {
            if (r.GetString(0) != TextBox1.Text)
            {
                TextBox1.Text = "";
                flag = false;
                Response.Write("<alert>输入的密码有误</alert>");
                
            }
        }
       
        if (flag)
        {
            string change = "";
            if (Request.Cookies["info"].Values["manager1"].ToString() == "no")
            {

                change = "update people set 密码='" + TextBox2.Text + "' where 昵称='" + Session["nowpos"].ToString() + "'";
            }
            else
                change = "update manager set 密码='" + TextBox2.Text + "' where 管理员姓名='" + Session["nowpos"].ToString() + "'"; 
            OleDbCommand c = new OleDbCommand(change,con);
            c.ExecuteNonQuery();
            Panel1.Visible = false;
            Panel2.Visible = true;
        }
      

        con.Close();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
       // Response.Write("<script>windows.close()</script>");
        this.Response.Write("<script language=javascript>window.close();</script>");
    }
}