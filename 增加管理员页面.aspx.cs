using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
public partial class 增加管理员页面 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
           // Panel1.Attributes.Add("style", "display:block");
           // Panel2.Attributes.Add("style", "display:none");
            Panel2.Visible = false;
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        String strConnection = "Provider=Microsoft.Ace.OleDb.12.0; Data Source=" + Server.MapPath("data.mdb");
        OleDbConnection con = new OleDbConnection(strConnection);
        con.Open();
        string str = "insert into manager(管理员姓名,注册时间,密码) values('" + Convert.ToString(TextBox1.Text) +  "','" + System.DateTime.Now.ToString() + "','"+TextBox2.Text+"')";
        OleDbCommand o = new OleDbCommand(str,con);
        o.ExecuteNonQuery();
        con.Close();
        Panel1.Attributes.Add("style","display:none");
       // Panel2.Attributes.Remove("dispa");
        Panel2.Visible = true;
    }
   
    protected void Timer1_Tick(object sender, EventArgs e)
    {
       Response.Write("<script >window.dialogArguments.parent.location.href=window.dialogArguments.parent.location.href;</script>");
        //Response.Write("<script>opener.parent.location.reload();</script>");
        Response.Write("<script>window.close()</script>");
    }
}