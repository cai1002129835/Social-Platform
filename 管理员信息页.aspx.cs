using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
using System.Text.RegularExpressions;
public partial class 管理员信息页 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        int count = ((GridViewRow)((Button)sender).Parent.Parent).RowIndex;
        string name = GridView1.Rows[count].Cells[0].Text;
        if (name == "admin")
        {
            Response.Write("<Script language='JavaScript'>alert('无法删除该管理员！');</Script>");
            return;
        }
        String strConnection = "Provider=Microsoft.Ace.OleDb.12.0; Data Source=" + Server.MapPath("data.mdb");
        OleDbConnection con = new OleDbConnection(strConnection);
        con.Open();
        string order = "delete from manager where 管理员姓名='" + name + "'";
        OleDbCommand o = new OleDbCommand(order,con);
        o.ExecuteNonQuery();
        con.Close();
        Response.Redirect("管理员信息页.aspx");
    }
}