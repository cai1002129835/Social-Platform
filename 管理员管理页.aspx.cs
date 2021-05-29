using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
using System.Text.RegularExpressions;
public partial class 管理员管理页 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        ///思路，从数据库中取出的数据是一样的，根据选择的排序方式不同而进行不同显示
        ///
        if (Request.Cookies["info"] == null)
            Response.Redirect("登陆页面.aspx");
        // Response.Write(Request.Cookies["info"].Value);
        string order = "";
        string order1 = "";
        string order2 = "";
        if (DropDownList1.SelectedValue == "按被举报时间")
            order = "select 举报人,举报用户,举报原因,举报时间 from [reportpeople] where 处理=0 order by 举报时间";
        else if (DropDownList1.SelectedValue == "按被举报原因")
        {
            order = "select 举报人,举报用户,举报原因,举报时间 from [reportpeople] where 处理=0 order by 举报原因";
        }
        else if (DropDownList1.SelectedValue == "按被举报用户")
        {
            order = "select 举报人,举报用户,举报原因,举报时间 from [reportpeople] where 处理=0 order by 举报用户";
        }
        else
        {
            order = "select 举报人,举报用户,举报原因,举报时间,count(举报用户) from [reportpeople] where 处理=0  group by 举报人,举报用户,举报原因,举报时间 order by count(举报用户)";
        }
        if (DropDownList2.SelectedValue == "按被举报时间")
            order1 = "select 举报人,举报用户,举报原因,举报微博,举报时间,原创 from [reportweibo] where 处理=0 order by 举报时间 desc";
        else if (DropDownList2.SelectedValue == "按被举报原因")
        {
            order1 = "select 举报人,举报用户,举报原因,举报微博,举报时间,原创 from [reportweibo] where 处理=0 order by 举报原因";
        }
        else if (DropDownList2.SelectedValue == "按被举报微博")
        {
            order1 = "select 举报人,举报用户,举报原因,举报微博,举报时间,原创 from [reportweibo] where 处理=0 order by 举报微博";
        }
        else
            order1 = "select 举报人,举报用户,举报原因,举报微博,举报时间,原创,count(举报微博) from [reportweibo] where 处理=0 group by 举报人,举报用户,举报原因,举报微博,举报时间,原创  order by count(举报微博) desc";
        if (DropDownList3.SelectedValue == "按被举报时间")
            order2 = "select 举报人,举报用户,举报原因,举报评论,举报时间 from [reportview] where 处理=0 order by 举报时间 desc";
        else if (DropDownList3.SelectedValue == "按被举报原因")
            order2 = "select 举报人,举报用户,举报原因,举报评论,举报时间 from [reportview] where 处理=0 order by 举报原因";
        else if (DropDownList3.SelectedValue == "按被举报评论")
            order2 = "select 举报人,举报用户,举报原因,举报评论,举报时间 from [reportview] where 处理=0 order by 举报评论";
        else
            order2 = "select 举报人,举报用户,举报原因,举报评论,举报时间,count(举报评论) from [reportview] where 处理=0 group by 举报人,举报用户,举报原因,举报评论,举报时间 order by count(举报评论)";
        getdata(order, order1, order2);
        GridView1.DataSource = Session["dt"];
        GridView1.DataBind();
        GridView2.DataSource = Session["dt1"];
        GridView2.DataBind();
        GridView3.DataSource = Session["dt2"];
        GridView3.DataBind();
        createg1((DataTable)Session["dt"]);
        createg2((DataTable)Session["dt1"]);
        createg3((DataTable)Session["dt2"]);

    }
    public void getdata(string order, string order1, string order2)
    {
        String strConnection = "Provider=Microsoft.Ace.OleDb.12.0; Data Source=" + Server.MapPath("data.mdb");
        OleDbConnection con = new OleDbConnection(strConnection);
        con.Open();

        OleDbDataAdapter o = new OleDbDataAdapter(order, con);
        DataSet ds = new DataSet();
        o.Fill(ds, "type");
        DataTable dt = new DataTable();
        dt = ds.Tables["type"];
        Session["dt"] = dt;


        OleDbDataAdapter o1 = new OleDbDataAdapter(order1, con);
        DataSet ds1 = new DataSet();
        o1.Fill(ds1, "type");
        DataTable dt1 = new DataTable();
        dt1 = ds1.Tables["type"];
        Session["dt1"] = dt1;


        OleDbDataAdapter o2 = new OleDbDataAdapter(order2, con);
        DataSet ds2 = new DataSet();
        o2.Fill(ds2, "type");
        DataTable dt2 = new DataTable();
        dt2 = ds2.Tables["type"];
        Session["dt2"] = dt2;
        con.Close();
    }
    public void createg1(DataTable dt)
    {
        for (int i = 0; i<GridView1.PageSize &&i +GridView1.PageIndex*GridView1.PageSize< dt.Rows.Count; i++)
        {

            LinkButton name, fromname;
            Label l1, l2, l3;
            name = (LinkButton)GridView1.Rows[i].FindControl("name");
            name.Text = dt.Rows[i + GridView1.PageIndex * GridView1.PageSize][1].ToString();
            fromname = (LinkButton)GridView1.Rows[i].FindControl("fromname");
            fromname.Text = dt.Rows[i + GridView1.PageIndex * GridView1.PageSize][0].ToString();
            l1 = (Label)GridView1.Rows[i].FindControl("reason");
            l1.Text = dt.Rows[i + GridView1.PageIndex * GridView1.PageSize][2].ToString();
            l2 = (Label)GridView1.Rows[i].FindControl("time");
            l2.Text = dt.Rows[i + GridView1.PageIndex * GridView1.PageSize][3].ToString();
            l3 = (Label)GridView1.Rows[i].FindControl("count");
            String strConnection = "Provider=Microsoft.Ace.OleDb.12.0; Data Source=" + Server.MapPath("data.mdb");
            OleDbConnection con = new OleDbConnection(strConnection);
            con.Open();
            string order = "select count(*) from [reportpeople] where 举报用户='" + Convert.ToString(name.Text) + "'";
            OleDbCommand o = new OleDbCommand(order, con);
            int cnt = (int)o.ExecuteScalar();
            l3.Text = "" + cnt;
            con.Close();
        }
    }
    public void createg2(DataTable dt)
    {
        for (int i = 0; i < GridView2.PageSize && i + GridView2.PageIndex * GridView2.PageSize < dt.Rows.Count; i++)
        {
            LinkButton name, fromname;
            Label l1, l2, l3, l4;
            Image img;
            name = (LinkButton)GridView2.Rows[i].FindControl("name");
            name.Text = dt.Rows[i + GridView2.PageSize * GridView2.PageIndex][1].ToString();
            fromname = (LinkButton)GridView2.Rows[i].FindControl("fromname");
            fromname.Text = dt.Rows[i + GridView2.PageSize * GridView2.PageIndex][0].ToString();
            l1 = (Label)GridView2.Rows[i].FindControl("reason");
            l1.Text = dt.Rows[i + GridView2.PageSize * GridView2.PageIndex][2].ToString();
            l4 = (Label)GridView2.Rows[i].FindControl("content");
            l4.Text = dt.Rows[i + GridView2.PageSize * GridView2.PageIndex][3].ToString();
            //string[] arr = l4.Text.Split(':');
            int n = l4.Text.IndexOf("/");

            if (n < 0)
                n = l4.Text.Length;
            l4.Text = l4.Text.Substring(0, n);
            Label l5 = (Label)GridView2.Rows[i].FindControl("ori");
            l5.Text = dt.Rows[i + GridView2.PageSize * GridView2.PageIndex][5].ToString();
            l2 = (Label)GridView2.Rows[i].FindControl("time");
            l2.Text = dt.Rows[i + GridView2.PageSize * GridView2.PageIndex][4].ToString();
            l3 = (Label)GridView2.Rows[i].FindControl("count");
            String strConnection = "Provider=Microsoft.Ace.OleDb.12.0; Data Source=" + Server.MapPath("data.mdb");
            OleDbConnection con = new OleDbConnection(strConnection);
            con.Open();
            string order = "select count(*) from [reportweibo] where 举报微博='" + Convert.ToString(l4.Text) + "'";
            OleDbCommand o = new OleDbCommand(order, con);
            int cnt = (int)o.ExecuteScalar();
            l3.Text = "" + cnt;
            string order1 = "select 处罚结束时间 from blacklist where 用户昵称='" + name.Text + "'";
            OleDbCommand o1 = new OleDbCommand(order1, con);
            OleDbDataReader r = o1.ExecuteReader();
            while (r.Read())
            {
              
               if (r.GetDateTime(0).CompareTo(System.DateTime.Now)>0)
                   
                {
                    img = (Image)GridView2.Rows[i].FindControl("warn");
                    img.Visible = true;
                } 
            }
           
            con.Close();
        }
    }
    public void createg3(DataTable dt)
    {
        for (int i = 0;i<GridView3.PageSize && i +GridView3.PageIndex*GridView3.PageSize< dt.Rows.Count; i++)
        {
            LinkButton name, fromname;
            Label l1, l2, l3, l4;
            Image img;
            name = (LinkButton)GridView3.Rows[i].FindControl("name");
            name.Text = dt.Rows[i + GridView3.PageIndex * GridView3.PageSize][1].ToString();
            fromname = (LinkButton)GridView3.Rows[i].FindControl("fromname");
            fromname.Text = dt.Rows[i + GridView3.PageIndex * GridView3.PageSize][0].ToString();
            l1 = (Label)GridView3.Rows[i].FindControl("reason");
            l1.Text = dt.Rows[i + GridView3.PageIndex * GridView3.PageSize][2].ToString();
            l4 = (Label)GridView3.Rows[i].FindControl("content");
            l4.Text = dt.Rows[i + GridView3.PageIndex * GridView3.PageSize][3].ToString();




            l2 = (Label)GridView3.Rows[i].FindControl("time");
            l2.Text = dt.Rows[i + GridView3.PageIndex * GridView3.PageSize][4].ToString();
            l3 = (Label)GridView3.Rows[i].FindControl("count");
            String strConnection = "Provider=Microsoft.Ace.OleDb.12.0; Data Source=" + Server.MapPath("data.mdb");
            OleDbConnection con = new OleDbConnection(strConnection);
            con.Open();
            string order = "select count(*) from [reportview] where 举报评论='" + Convert.ToString(l4.Text) + "'";
            OleDbCommand o = new OleDbCommand(order, con);
            int cnt = (int)o.ExecuteScalar();
            l3.Text = "" + cnt;
            string order1 = "select 处罚结束时间 from blacklist where 用户昵称='" + name.Text + "'";
            OleDbCommand o1 = new OleDbCommand(order1, con);
            OleDbDataReader r = o1.ExecuteReader();
            while (r.Read())
            {
                bool flag = true;
                if (r.GetDateTime(0).CompareTo(System.DateTime.Now) >0)
                {
                    flag = false;
                }
                if (flag)
                {
                    img = (Image)GridView2.Rows[i].FindControl("warn");
                    img.Visible = true;
                }
            }
            con.Close();
        }
    }
    protected void name_Click(object sender, EventArgs e)
    {
        int count = ((GridViewRow)((LinkButton)sender).Parent.Parent).RowIndex;
        LinkButton link = (LinkButton)GridView1.Rows[count].FindControl("name");
        Session["nowpos"] = link.Text;
        Response.Redirect("我的封面.aspx");
    }
    protected void fromname_Click(object sender, EventArgs e)
    {
        int count = ((GridViewRow)((LinkButton)sender).Parent.Parent).RowIndex;
        LinkButton link = (LinkButton)GridView1.Rows[count].FindControl("fromname");
        Session["nowpos"] = link.Text;
        Response.Redirect("我的封面.aspx");
    }
    protected void deal_Click(object sender, EventArgs e)
    {
        int count = ((GridViewRow)((Button)sender).Parent.Parent).RowIndex;
        Session["table"]="reportpeople";                                   
        LinkButton link = (LinkButton)GridView1.Rows[count].FindControl("name");
        Label l = (Label)GridView1.Rows[count].FindControl("time");
        Session["处理对象"] = "用户";
        Session["用户"] = link.Text; 
        Session["time"] =l.Text;
        Response.Write("<script>window.showModelessDialog('举报处理页.aspx',window,'dialogHeight:350px;dialogWidth:600px;help:0;center:yes;resizable:0;status:0;scroll:no')</script>");
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        int count = ((GridViewRow)((Button)sender).Parent.Parent).RowIndex;
        Session["table"] = "reportweibo";
        LinkButton link = (LinkButton)GridView2.Rows[count].FindControl("name");
        Label l = (Label)GridView2.Rows[count].FindControl("time");
        Session["处理对象"] = "用户";
        Session["用户"] = link.Text;
        Session["time"] = l.Text;
        Response.Write("<script>window.showModelessDialog('举报处理页.aspx',window,'dialogHeight:350px;dialogWidth:600px;help:0;center:yes;resizable:0;status:0;scroll:no')</script>");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        int count = ((GridViewRow)((Button)sender).Parent.Parent).RowIndex;
        Label ori= (Label)GridView2.Rows[count].FindControl("ori");
   
        bool flag=true;
        if(ori.Text=="0")
            flag=false;
            
        String strConnection = "Provider=Microsoft.Ace.OleDb.12.0; Data Source=" + Server.MapPath("data.mdb");
        OleDbConnection con = new OleDbConnection(strConnection);
        con.Open(); 
        Label l1 = (Label)GridView2.Rows[count].FindControl("content");
        LinkButton name = (LinkButton)GridView2.Rows[count].FindControl("name");
        string deletestr = "";
        if (flag)
        {         
            string str = l1.Text;
            string order = "update [post]  set 原创内容=null,原创昵称=null  where 原创内容 ='" + l1.Text + "'  and 原创=0 and 原创昵称='" + name.Text+ "'";
            OleDbCommand o = new OleDbCommand(order, con);
            o.ExecuteNonQuery();
            deletestr = "delete from [post] where 原创内容='" + l1.Text + "' and 原创=1 and 昵称='" + name.Text + "'";
        }
        else
            deletestr = "delete from [post] where 转发内容='" + ori.Text+ "' and 原创=0 and 昵称='" + name.Text + "'";
        string order1 = "update reportweibo set 处理=1,处理人='" + Request.Cookies["info"].Values["nickname"].ToString() + "' where 举报微博='" + l1.Text + "' and 举报用户='"+name.Text+"'";
        OleDbCommand up = new OleDbCommand(order1, con);
        up.ExecuteNonQuery();
        
        OleDbCommand d = new OleDbCommand(deletestr,con);
        d.ExecuteNonQuery();
        con.Close();
        Response.Redirect("管理员管理页.aspx");
    }
    protected void Button1_Click1(object sender, EventArgs e)
    {
        Session["table"] = "reportview";
        int count = ((GridViewRow)((Button)sender).Parent.Parent).RowIndex;
        LinkButton link = (LinkButton)GridView3.Rows[count].FindControl("name");
        Label l = (Label)GridView3.Rows[count].FindControl("time");
        Session["处理对象"] = "用户";
        Session["用户"] = link.Text;
        Session["time"] = l.Text;
        Response.Write("<script>window.showModelessDialog('举报处理页.aspx',window,'dialogHeight:350px;dialogWidth:600px;help:0;center:yes;resizable:0;status:0;scroll:no')</script>");
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        int count = ((GridViewRow)((Button)sender).Parent.Parent).RowIndex;
        Label l1 = (Label)GridView3.Rows[count].FindControl("content");
        LinkButton link1 = (LinkButton)GridView3.Rows[count].FindControl("name");
        String strConnection = "Provider=Microsoft.Ace.OleDb.12.0; Data Source=" + Server.MapPath("data.mdb");
        OleDbConnection con = new OleDbConnection(strConnection);
        con.Open();
        string order = "delete  from comment where 昵称='" + link1.Text + "' and 评论='" + l1.Text + "'";
        string order1 = "update reportview set 处理=1,处理人='" + Request.Cookies["info"].Values["nickname"].ToString() + "' where 举报用户='" + link1.Text + "' and 举报评论='" + l1.Text + "'";
        OleDbCommand o = new OleDbCommand(order, con);
        o.ExecuteNonQuery();
        OleDbCommand o1 = new OleDbCommand(order1, con);
        o1.ExecuteNonQuery();
        con.Close();
        Response.Redirect("管理员管理页.aspx");
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        createg1((DataTable)Session["dt"]);
    }
    protected void GridView2_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView2.PageIndex = e.NewPageIndex;
        createg2((DataTable)Session["dt1"]);
    }
    protected void GridView3_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView3.PageIndex = e.NewPageIndex;
        createg3((DataTable)Session["dt2"]);
    }
    protected void GridView3_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        e.Row.Attributes.Add("onmouseover", "Color=this.style.backgroundColor;this.style.backgroundColor='white';");
        e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=Color");
       
    }
    protected void GridView2_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        e.Row.Attributes.Add("onmouseover", "Color=this.style.backgroundColor;this.style.backgroundColor='white'");
        e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=Color");
    }
    protected void GridView3_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        e.Row.Attributes.Add("onmouseover", "Color=this.style.backgroundColor;this.style.backgroundColor='white'");
        e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=Color");
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        int count = ((GridViewRow)((Button)sender).Parent.Parent).RowIndex;
        Label ori = (Label)GridView2.Rows[count].FindControl("ori");
        String strConnection = "Provider=Microsoft.Ace.OleDb.12.0; Data Source=" + Server.MapPath("data.mdb");
        OleDbConnection con = new OleDbConnection(strConnection);
        con.Open();
        Label l1 = (Label)GridView2.Rows[count].FindControl("content");
        LinkButton name = (LinkButton)GridView2.Rows[count].FindControl("name");       
        string order1 = "update reportweibo set 处理=1,处理人='" + Request.Cookies["info"].Values["nickname"].ToString() + "' where 举报微博='" + l1.Text + "' and 举报用户='" + name.Text + "'";
        OleDbCommand up = new OleDbCommand(order1, con);
        up.ExecuteNonQuery();
      
        con.Close();
        Response.Redirect("管理员管理页.aspx");
    }
  
}
