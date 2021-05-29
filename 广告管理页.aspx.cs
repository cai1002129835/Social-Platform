using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
using System.Text.RegularExpressions;
public partial class 广告管理页 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        bind();
    }
    public void bind()
    {
        String strConnection = "Provider=Microsoft.Ace.OleDb.12.0; Data Source=" + Server.MapPath("data.mdb");
        OleDbConnection con = new OleDbConnection(strConnection);
        con.Open();
        string deletestr = "delete from advertisement where 结束时间< now()";
        OleDbCommand deleteo = new OleDbCommand(deletestr,con);
        deleteo.ExecuteNonQuery();
        string now = "select 名称,图片,描述信息,开始时间,结束时间,展示,链接 from advertisement where 开始时间<  now()  and 结束时间>  now() ";
        OleDbDataAdapter o = new OleDbDataAdapter(now, con);
        DataSet ds = new DataSet();
        o.Fill(ds, "type");
        DataTable dt = ds.Tables["type"];
        GridView1.DataSource = dt;
        GridView1.DataBind();
        for (int i = 0; i < GridView1.PageSize && i + GridView1.PageSize * GridView1.PageIndex < dt.Rows.Count; i++)
        {
            Label l1, l2, l3, l4,l5;
            Image i1;
            l1 = (Label)GridView1.Rows[i].FindControl("Label5");
            l2 = (Label)GridView1.Rows[i].FindControl("Label6");
            l3 = (Label)GridView1.Rows[i].FindControl("Label7");
            l4 = (Label)GridView1.Rows[i].FindControl("Label8");
            l5 = (Label)GridView1.Rows[i].FindControl("Label11");
            i1 = (Image)GridView1.Rows[i].FindControl("Image1");
            l1.Text = dt.Rows[i + GridView1.PageSize * GridView1.PageIndex][0].ToString();
            l2.Text = dt.Rows[i + GridView1.PageSize * GridView1.PageIndex][3].ToString();
            l3.Text = dt.Rows[i + GridView1.PageSize * GridView1.PageIndex][4].ToString();
            l4.Text = dt.Rows[i + GridView1.PageSize * GridView1.PageIndex][2].ToString();
            l5.Text = dt.Rows[i + GridView1.PageSize * GridView1.PageIndex][6].ToString();
            i1.ImageUrl = dt.Rows[i + GridView1.PageSize * GridView1.PageIndex][1].ToString();

        }
        con.Close();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        int count = ((GridViewRow)((Button)sender).Parent.Parent).RowIndex;
        Label l1 = (Label)GridView1.Rows[count].FindControl("Label5");
        Label l2 = (Label)GridView1.Rows[count].FindControl("Label6");
        Label l3 = (Label)GridView1.Rows[count].FindControl("Label7");
        Label l4 = (Label)GridView1.Rows[count].FindControl("Label8");
        Label l5 = (Label)GridView1.Rows[count].FindControl("Label11");
        Session["广告名"] = l1.Text;
        Session["开始时间"] = l2.Text;
        Session["结束时间"] = l3.Text;
        Session["描述信息"] = l4.Text;
        Session["链接"] = l5.Text;
        Response.Write("<script>window.showModelessDialog('增加广告页面.aspx',window,'dialogHeight:700px;dialogWidth:600px;help:0;center:yes;resizable:0;status:0;scroll:no')</script>");
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        int count = ((GridViewRow)((Button)sender).Parent.Parent).RowIndex;
        Label l1 = (Label)GridView1.Rows[count].FindControl("Label5");
        string order = "delete  from [advertisement] where 名称='"+l1.Text+"'";
        String strConnection = "Provider=Microsoft.Ace.OleDb.12.0; Data Source=" + Server.MapPath("data.mdb");
        OleDbConnection con = new OleDbConnection(strConnection);
        con.Open();
        OleDbCommand o = new OleDbCommand(order,con);
        o.ExecuteNonQuery();
        con.Close();
        Response.Redirect("广告管理页.aspx");
    }
    protected void Button1_Click1(object sender, EventArgs e)
    {
       
    }

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
       
    }
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Attributes.Add("onmouseover", "Color=this.style.backgroundColor;this.style.backgroundColor='#FFFF99'");
            e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=Color");
        }
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        Session["广告名"] = "";
        Response.Write("<script>window.showModelessDialog('增加广告页面.aspx',window,'dialogHeight:700px;dialogWidth:600px;help:0;center:yes;resizable:0;status:0;scroll:no')</script>");
    }
}