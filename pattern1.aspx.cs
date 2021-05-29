using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class pattern1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Cookies["info"] != null)
        {
            LinkButton1.Text = Convert.ToString(Request.Cookies["info"].Values["nickname"]);

        }
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Session["nowpos"] = Request.Cookies["info"].Values["nickname"].ToString();
        Response.Write("<script language='JavaScript'>parent.window.location='Defaul2.aspx';</script>");
    }
    protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
    {
        if (Request.Cookies["info"]!=null)
        {
            TimeSpan ts = new TimeSpan(-1, 0, 0, 0);
            Request.Cookies["info"].Expires = System.DateTime.Now.Add(ts);
            Response.AppendCookie(Request.Cookies["info"]);
            Response.Write("<script language='JavaScript'>parent.window.location='登陆页面.aspx';</script>");
        }
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        //Response.Redirect("Defaul2.aspx");
        Session["nowpos"] = Request.Cookies["info"].Values["nickname"].ToString();
        Response.Write("<script language='JavaScript'>parent.window.location='我的封面.aspx';</script>");
    }
    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void ImageButton6_Click(object sender, ImageClickEventArgs e)
    {
        if (!TextBox1.Text.Equals(""))
        {
            Session["searchaim"] = 0;
            Session["searchkey"] = TextBox1.Text;
            // Response.Write("<script language='text/javascript'>window.parent.location.href='微博搜索结果页面.aspx';</script>");
            Response.Write("<script type='text/javascript'>window.parent.location.href='微博搜索结果页面.aspx';</script>");
        }
        else
        {
            Response.Write("<script type='text/javascript'>window.parent.location.href='微博搜索.aspx';</script>");
        }
    }
    protected void ImageButton5_Click(object sender, ImageClickEventArgs e)
    {
        Session["nowpos"] = Request.Cookies["info"].Values["nickname"].ToString();
        Response.Write("<script type='text/javascript'>window.parent.location.href='Defaul2.aspx';</script>");
    }
    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        Response.Write("<script type='text/javascript'>window.parent.location.href='发现.aspx';</script>");
    }
    protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
    {
        Session["showmore"] = 2;///显示与私信有关的内容
    }
}