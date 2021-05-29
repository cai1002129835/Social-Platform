using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
public partial class 授权页面 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            String strConnection = "Provider=Microsoft.Ace.OleDb.12.0; Data Source=" + Server.MapPath("data.mdb");
            OleDbConnection con = new OleDbConnection(strConnection);
            con.Open();
            string order = "select 管理员姓名,注册时间 from [manager] ";
            OleDbDataAdapter a = new OleDbDataAdapter(order, con);
            DataSet ds = new DataSet();
            a.Fill(ds, "type");
            DataTable dt = new DataTable();
            dt = ds.Tables["type"];
             dt.Rows.RemoveAt(0);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Panel p = (Panel)GridView1.Rows[i].FindControl("Panel2");
                p.Visible = true;
                LinkButton link = (LinkButton)GridView1.Rows[i].FindControl("name");
                link.Text = dt.Rows[i][0].ToString();
                Label l = (Label)GridView1.Rows[i].FindControl("time");
                l.Text = dt.Rows[i][1].ToString();
         
            }

            con.Close();

        }

    }
    protected void setpower_Click(object sender, EventArgs e)
    {

    }
    protected void name_Click(object sender, EventArgs e)
    {
        int count = ((GridViewRow)((LinkButton)sender).Parent.Parent.Parent).RowIndex;
        LinkButton link1;
        link1 = (LinkButton)GridView1.Rows[count].FindControl("name");
        Session["nowpos"] = link1.Text;
        //   Response.Write("<script type='text/javascript'>window.parent.location.href='.aspx';</script>");
    }
    protected void deletemanager_Click(object sender, EventArgs e)
    {
        int count = ((GridViewRow)((Button)sender).Parent.Parent.Parent).RowIndex;
        LinkButton link1;
        link1 = (LinkButton)GridView1.Rows[count].FindControl("name");
        Panel p2;
        p2 = (Panel)GridView1.Rows[count].FindControl("Panel2");
        String strConnection = "Provider=Microsoft.Ace.OleDb.12.0; Data Source=" + Server.MapPath("data.mdb");
        OleDbConnection con = new OleDbConnection(strConnection);
        con.Open();
        string order = "delete from [manager] where 管理员姓名='" + Convert.ToString(link1.Text) + "'";
        OleDbCommand o = new OleDbCommand(order, con);
        o.ExecuteNonQuery();
        con.Close();
        p2.Attributes.Add("style", "display:none");
        Panel1.Visible = true;
        Panel1.Style.Value= "display:block";

    }
    protected void Timer1_Tick(object sender, EventArgs e)
    {
        Panel1.Style.Value = "display:none";
        Panel1.Visible = false;
    }
}