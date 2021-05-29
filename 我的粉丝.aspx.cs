using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
public partial class 我的粉丝 : System.Web.UI.Page
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
            char ch = Convert.ToChar(34);
            string order;
            order = "select people.昵称,people.头像,people.简介 from [people],[focus] where focus.关注的人=" + ch + Session["nowpos"].ToString() + ch + "and focus.用户昵称=people.昵称;";
            OleDbDataAdapter c1 = new OleDbDataAdapter(order, con);
            DataSet ds = new DataSet();
            c1.Fill(ds, "type");
            DataTable dt = new DataTable();        //数据表
            dt = ds.Tables["type"];

            string order1;
            order1 = "select count(用户昵称) from [focus] where 关注的人=" + ch + Session["nowpos"].ToString() + ch;
            OleDbCommand d1 = new OleDbCommand(order1,con);
            int count = (int)d1.ExecuteScalar();
            amount.Text ="  "+Convert.ToString(count);
            GridView1.DataSource = ds;
            GridView1.DataBind();

            ImageButton m1;
            Label l1,l2;
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
   /* public OleDbDataReader imgbind()
    {
        char ch = Convert.ToChar(34);
        string str="select people.头像 from [people],[focus] where focus.关注的人=" + ch + Request.Cookies["info"].Values["user"].ToString() + ch + "and focus.用户名=people.用户名;";
        String strConnection = "Provider=Microsoft.Ace.OleDb.12.0; Data Source=" + Server.MapPath("data.mdb");
        OleDbConnection con = new OleDbConnection(strConnection); 
        OleDbCommand c = new OleDbCommand(str,con);
      //  Label9.Text = str;
        con.Open();
        return c.ExecuteReader();
    }
    public OleDbDataReader wordbind1()
    {
        char ch = Convert.ToChar(34);
        string str = "select people.简介 from [people],[focus] where focus.关注的人=" + ch + Request.Cookies["info"].Values["user"].ToString() + ch + "and focus.用户名=people.用户名;";
        String strConnection = "Provider=Microsoft.Ace.OleDb.12.0; Data Source=" + Server.MapPath("data.mdb");
        OleDbConnection con = new OleDbConnection(strConnection);

        OleDbCommand c = new OleDbCommand(str, con);
        //  Label9.Text = str;
        con.Open();
        return c.ExecuteReader();
    }
    public OleDbDataReader wordbind()
    {
        char ch = Convert.ToChar(34);
        string str = "select people.昵称 from [people],[focus] where focus.关注的人=" + ch + Request.Cookies["info"].Values["user"].ToString() + ch + "and focus.用户名=people.用户名;";
        String strConnection = "Provider=Microsoft.Ace.OleDb.12.0; Data Source=" + Server.MapPath("data.mdb");
        OleDbConnection con = new OleDbConnection(strConnection);

        OleDbCommand c = new OleDbCommand(str, con);
        //  Label9.Text = str;
        con.Open();
        return c.ExecuteReader();
    }*/


    protected void i1_Click(object sender, ImageClickEventArgs e)
    {
        int count = ((GridViewRow)((ImageButton)sender).Parent.Parent).RowIndex;
        Label l1 = (Label)GridView1.Rows[count].FindControl("Label9");

        // Request.Cookies["info"].Values["nowpos"] = Convert.ToString(l1.Text);
        //Response.Cookies["info"].Values.Set("nowpos", Convert.ToString(l1.Text));
Session["nowpos"]=l1.Text;
        Response.Cookies["info"].Values.Set("nickname", Request.Cookies["info"].Values["nickname"].ToString());
        Response.Cookies["info"].Values.Set("user", Request.Cookies["info"].Values["user"].ToString());
        Response.Cookies["info"].Values.Set("pd", Request.Cookies["info"].Values["pd"].ToString());
        Response.Cookies["info"].Expires = DateTime.Now.AddYears(1);
        Response.Redirect("我的封面.aspx");
    }
}