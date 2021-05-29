using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class pattern2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Cookies["info"] != null)
        {
            LinkButton1.Text = Request.Cookies["info"].Values["nickname"].ToString();
           /* if (LinkButton1.Text != "admin")
            {
                managerinfo.ImageUrl = "~/photo/nofriends_group.jpg";
                managerinfo.Attributes.Add("disabled","true");
                managerinfo.ToolTip = "没有权限";
                plusmanager.ImageUrl = "~/photo/无法增加管理员.png";
                plusmanager.Attributes.Add("disabled", "true");
                plusmanager.ToolTip = "没有权限";
            }*/
        }
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Session["nowpos"] = Request.Cookies["info"].Values["nickname"].ToString();
        Response.Redirect("管理员管理页.apsx");
    }
    protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
    {
        Response.Write("<script>window.showModelessDialog('增加管理员页面.aspx',window,'dialogHeight:350px;dialogWidth:600px;help:0;center:yes;resizable:0;status:0;scroll:no')</script>");
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        //Response.Redirect("Defaul2.aspx");
        Session["nowpos"] = Request.Cookies["info"].Values["nickname"].ToString();
        Response.Write("<script language='JavaScript'>parent.window.location='管理员管理页.aspx';</script>");
    }
    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    
    protected void ImageButton5_Click(object sender, ImageClickEventArgs e)
    {
        Session["nowpos"] = Request.Cookies["info"].Values["nickname"].ToString();
        Response.Write("<script type='text/javascript'>window.parent.location.href='Defaul2.aspx';</script>");
    }
    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        Response.Write("<script type='text/javascript'>window.parent.location.href='管理员信息页.aspx';</script>");
    }
    protected void logout_Click(object sender, ImageClickEventArgs e)
    {
        if (Request.Cookies["info"] != null)
        {
            TimeSpan ts = new TimeSpan(-1, 0, 0, 0);
            Request.Cookies["info"].Expires = System.DateTime.Now.Add(ts);
            Response.AppendCookie(Request.Cookies["info"]);
            Response.Write("<script language='JavaScript'>parent.window.location='登陆页面.aspx';</script>");
        }
    }
    protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
    {
        Response.Write("<script language='JavaScript'>parent.window.location='举报处理查看.aspx';</script>");
    }
    protected void ImageButton5_Click1(object sender, ImageClickEventArgs e)
    {
        Response.Write("<script language='JavaScript'>parent.window.location='广告管理页.aspx';</script>");
    }
}