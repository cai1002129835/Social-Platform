using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
using System.Text.RegularExpressions;
public partial class 举报处理查看 : System.Web.UI.Page
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
        string showorder = "select 举报用户,举报原因,处理人,封号,举报时间 from [reportpeople] where reportpeople.处理=1   order by reportpeople.举报时间 desc ";
        OleDbDataAdapter d = new OleDbDataAdapter(showorder, con);
        DataSet ds = new DataSet();
        d.Fill(ds, "type");
        DataTable dt = ds.Tables["type"];
        string showorder1 = "select 举报用户,举报原因,处理人,封号,举报时间,举报评论 from [reportview] where reportview.处理=1   order by reportview.举报时间 desc";
        string showorder2 = "select 举报用户,举报原因,处理人,封号,举报时间,举报微博 from [reportweibo] where reportweibo.处理=1   order by reportweibo.举报时间 desc";
        OleDbDataAdapter d1 = new OleDbDataAdapter(showorder1, con);
        DataSet ds1 = new DataSet();
        d1.Fill(ds1, "type");
        DataTable dt1 = ds1.Tables["type"];
        OleDbDataAdapter d2 = new OleDbDataAdapter(showorder2, con);
        DataSet ds2 = new DataSet();
        d2.Fill(ds2, "type");
        DataTable dt2 = ds2.Tables["type"];
        DataTable final = dt1.Clone();
        int i;
        for (i = 0; i < dt.Rows.Count; i++)
        {
            DataRow dr = dt.Rows[i];
            final.Rows.Add(dr.ItemArray);
        }
        if (dt1.Rows.Count != 0)
        {
            for (; i < dt.Rows.Count + dt1.Rows.Count; i++)
            {
                DataRow dr = dt1.Rows[i-dt.Rows.Count];
                final.Rows.Add(dr.ItemArray);
            }
        }
        if (dt2.Rows.Count != 0)
        {
            for (; i < dt.Rows.Count + dt1.Rows.Count + dt2.Rows.Count; i++)
            {
                DataRow dr = dt2.Rows[i-dt.Rows.Count-dt1.Rows.Count];
                final.Rows.Add(dr.ItemArray);
            }
        }
        GridView1.DataSource = final;
        GridView1.DataBind();
        for (i = 0; i < GridView1.PageSize && i + GridView1.PageSize * GridView1.PageIndex < final.Rows.Count; i++)
        {
            Label l1, l2, l3, l4,l5;
            l1 = (Label)GridView1.Rows[i].FindControl("Label2");
            l2 = (Label)GridView1.Rows[i].FindControl("Label4");
            l3 = (Label)GridView1.Rows[i].FindControl("Label6");
            l4 = (Label)GridView1.Rows[i].FindControl("Label8");
            l5 = (Label)GridView1.Rows[i].FindControl("Label10");
            l1.Text = final.Rows[i + GridView1.PageSize * GridView1.PageIndex][1].ToString();
            l2.Text = final.Rows[i + GridView1.PageSize * GridView1.PageIndex][2].ToString();
            if (final.Rows[i + GridView1.PageSize * GridView1.PageIndex][5].ToString() != null)
                l3.Text = final.Rows[i + GridView1.PageSize * GridView1.PageIndex][5].ToString();
            else
                l3.Text = "暂无";
            if (final.Rows[i + GridView1.PageSize * GridView1.PageIndex][3].ToString() == "1")
                l4.Text = "用户封号 删除违规信息";
            else
                l4.Text = "删除违规信息";
            l5.Text = final.Rows[i + GridView1.PageSize * GridView1.PageIndex][0].ToString();
        }
            con.Close();
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
    }
}