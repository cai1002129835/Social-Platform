using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
public partial class 关注的人 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        bind();
    }
    public void bind()
    {
      //  Response.Write(Request.Cookies["info"].Value);
        String strConnection = "Provider=Microsoft.Ace.OleDb.12.0; Data Source=" + Server.MapPath("data.mdb");
        OleDbConnection con = new OleDbConnection(strConnection);
        con.Open();
        char ch = Convert.ToChar(34);
        string order;
        order = "select people.昵称,people.头像,people.简介 from [people],[focus] where focus.用户昵称=" + ch + Session["nowpos"].ToString() + ch + "and focus.关注的人=people.昵称;";
        OleDbDataAdapter c1 = new OleDbDataAdapter(order, con);
        DataSet ds = new DataSet();
        c1.Fill(ds, "type");
        DataTable dt = new DataTable();        //数据表
        dt = ds.Tables["type"];

        string order1;
        order1 = "select count(关注的人) from [focus] where 用户昵称=" + ch + Session["nowpos"].ToString() + ch;
        OleDbCommand d1 = new OleDbCommand(order1, con);
        int count = (int)d1.ExecuteScalar();
        amount.Text = "  " + Convert.ToString(count);
        GridView1.DataSource = ds;
        GridView1.DataBind();

        ImageButton m1;
        Label l1, l2;
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            DataRowView d = dt.DefaultView[i];
            m1 = (ImageButton)GridView1.Rows[i].FindControl("i1");
            m1.ImageUrl = dt.Rows[i][1].ToString();
            m1.Visible = true;
            //  
            l1 = (Label)GridView1.Rows[i].FindControl("Label9");
            l1.Text = dt.Rows[i][0].ToString();

            l2 = (Label)GridView1.Rows[i].FindControl("Label10");
            l2.Text = dt.Rows[i][2].ToString();
        }
        con.Close();
    }
    protected void i1_Click(object sender, ImageClickEventArgs e)
    {
        int count = ((GridViewRow)((ImageButton)sender).Parent.Parent).RowIndex;
        Label l1 = (Label)GridView1.Rows[count].FindControl("Label9");

       
        Session["nowpos"] = l1.Text;

        Response.Redirect("我的封面.aspx");
    }
}