using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
using System.Text.RegularExpressions;
public partial class 增加广告页面 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["广告名"].ToString() != "")
            {
                TextBox1.Text = Session["广告名"].ToString();
                TextBox2.Text = Session["描述信息"].ToString();
                start.SelectedDate = Convert.ToDateTime(Session["开始时间"].ToString());
                end.SelectedDate = Convert.ToDateTime(Session["结束时间"].ToString());
                TextBox3.Text = Session["链接"].ToString();
            }
        }
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        if (Session["广告名"].ToString() == "")
        {
            string name = FileUpload1.FileName;
            //int size = FileUpload1.PostedFile.ContentLength;
            // string type = FileUpload1.PostedFile.ContentType;
            string ipath = Server.MapPath(@"~\image\") + name;
            string dpath;
            dpath = @"~\image\";
            dpath += name;
            FileUpload1.SaveAs(ipath);
            string order = "insert into advertisement(名称,图片,描述信息,开始时间,结束时间,链接) values('";
            order += TextBox1.Text;
            order += "','";
            order += dpath;
            order += "','";
            order += TextBox2.Text;
            order += "','";
            order += start.SelectedDate;
            order += "','";
            order += end.SelectedDate;
            order += "','";
            order += TextBox3.Text;
            order += "')";
            String strConnection = "Provider=Microsoft.Ace.OleDb.12.0; Data Source=" + Server.MapPath("data.mdb");
            OleDbConnection con = new OleDbConnection(strConnection);
            con.Open();
            OleDbCommand o = new OleDbCommand(order, con);
            o.ExecuteNonQuery();
            con.Close();
            Response.Write("<script >window.dialogArguments.location.href=window.dialogArguments.location.href;</script>");
            Response.Write("<script>window.close()</script>");
        }
        else
        {
            string name = FileUpload1.FileName;
            Response.Write(name);
           string order = "";
            if (name == "")
                order = "update [advertisement] set 名称='" + TextBox1.Text + "',描述信息='" + TextBox2.Text + "',开始时间='" + start.SelectedDate + "',结束时间='" + end.SelectedDate + "', 链接= '"+TextBox3.Text+"' where 名称='" + Session["广告名"].ToString() + "'";
            else
            {
                string ipath = Server.MapPath(@"~\image\") + name;
                string dpath;
                dpath = @"~\image\";
                dpath += name;
                FileUpload1.SaveAs(ipath);
                order = "update [advertisement] set 名称='" + TextBox1.Text + "',描述信息='" + TextBox2.Text + "',开始时间='" + start.SelectedDate + "',结束时间='" + end.SelectedDate + "',图片='" + dpath + "',链接='" + TextBox3.Text+"'  where 名称='" + Session["广告名"].ToString() + "'";
            }
            String strConnection = "Provider=Microsoft.Ace.OleDb.12.0; Data Source=" + Server.MapPath("data.mdb");
            OleDbConnection con = new OleDbConnection(strConnection);
            con.Open();
            OleDbCommand o = new OleDbCommand(order, con);
            o.ExecuteNonQuery();
            con.Close();
            Response.Write("<script >window.dialogArguments.location.href=window.dialogArguments.location.href;</script>");
            Response.Write("<script>window.close()</script>");
        }
    }
    protected void Button4_Click(object sender, EventArgs e)
    {

    }
    protected void start_SelectionChanged(object sender, EventArgs e)
    {

    }
    protected void end_SelectionChanged(object sender, EventArgs e)
    {

    }
    protected void Button4_Click1(object sender, EventArgs e)
    {
        Response.Write("<script>window.close()</script>");
    }
}