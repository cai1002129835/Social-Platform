using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class 微博搜索 : System.Web.UI.Page
{
    int choose = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (Convert.ToString(TextBox1.Text) != "")
        {
            Session["searchkey"] = TextBox1.Text;
            Session["searchaim"] = Convert.ToString(choose);
            Response.Redirect("微博搜索结果页面.aspx");
        }
        else
            Label1.Visible = true;
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        choose = 0;
        LinkButton1.Style.Add("Color","#FF0066");
        LinkButton2.Style.Add("Color", "black");
        LinkButton3.Style.Add("Color", "black");
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        choose = 1;
        LinkButton2.Style.Add("Color", "#FF0066");
        LinkButton1.Style.Add("Color", "black");
        LinkButton3.Style.Add("Color", "black");
    }
    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        choose = 2;
        LinkButton3.Style.Add("Color", "#FF0066");
        LinkButton1.Style.Add("Color", "black");
        LinkButton2.Style.Add("Color", "black");
    }
}