using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
public partial class 举报页面 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Panel2.Visible = false;
            if (Session["举报"].ToString() == "举报用户")
            {

                RadioButtonList1.Attributes.Add("style", "display:none");
                Label3.Text = "用户";
                name.Text = "@" + Session["nowpos"].ToString();
                ImageButton1.ImageUrl = Session["头像"].ToString();
                Label2.Text = Session["简介"].ToString();

            }
            else if (Session["举报"].ToString() == "举报微博")
            {
                RadioButtonList2.Attributes.Add("style", "display:none");
                Label3.Text = "微博";
                name.Text = "@" + Session["用户名"].ToString();
                ImageButton1.ImageUrl = Session["头像"].ToString();
                int n = Session["内容"].ToString().IndexOf("/");
                //Session[""]
                // string[] arr = Session["内容"].ToString().Split(':');
                if (n >= 0)
                    // Label2.Text = dealimg(.Substring(0,index));
                    Session["内容"] = Session["内容"].ToString().Substring(0, n);

                Label2.Text = Session["内容"].ToString();
            }
            else
            {

                RadioButtonList2.Attributes.Add("style", "display:none");
                Label3.Text = "发的评论";
                name.Text = "@" + Session["用户名"].ToString();
                ImageButton1.ImageUrl = Session["头像"].ToString();
                Label2.Text = dealimg(Session["内容"].ToString());
            }
        }
    }
    protected void post_Click(object sender, EventArgs e)
    {
        string ord = "";
        if (Session["举报"].ToString() == "举报用户")
        {
            ord = "insert into reportpeople(举报人,举报用户,举报原因,举报时间,处理) values('" + Request.Cookies["info"].Values["nickname"].ToString() + "','" + Session["nowpos"].ToString() + "','" + RadioButtonList2.SelectedValue + "','" + System.DateTime.Now.ToString() + "',0)";

        }
        else if (Session["举报"].ToString() == "举报微博")
        {
            ord = "insert into reportweibo(举报人,举报用户,举报原因,举报微博,举报时间,处理,原创) values('" + Request.Cookies["info"].Values["nickname"].ToString() + "','" + Session["用户名"].ToString() + "','" + RadioButtonList1.SelectedValue + "','" + Session["内容"].ToString() + "','" + System.DateTime.Now.ToString() + "',0,"+Convert.ToInt16(Session["原创"].ToString())+")";
        }
        else
        {

            ord = "insert into reportview(举报人,举报用户,举报原因,举报评论,举报时间,处理) values('" + Request.Cookies["info"].Values["nickname"].ToString() + "','" + Session["用户名"].ToString() + "','" + RadioButtonList1.SelectedValue + "','" + Session["内容"].ToString() + "','" + System.DateTime.Now.ToString() + "',0)";
        }
        String strConnection = "Provider=Microsoft.Ace.OleDb.12.0; Data Source=" + Server.MapPath("data.mdb");
        OleDbConnection con = new OleDbConnection(strConnection);
        con.Open();
        OleDbCommand o = new OleDbCommand(ord, con);
        o.ExecuteNonQuery();
        con.Close();
        //  Panel1.Visible = false;
        Panel1.Attributes.Add("style", "display:none");
        Panel2.Visible = true;
    }
    public string dealimg(string str)///用来处理表情路径
    {
        string[] a = new string[] { "{人}", "{哭泣}", "{亲吻}", "{抽烟}", "{卖萌}", "{发火}", "{可爱}", "{说谎}", "{难过}", "{大笑}", "{委屈}", "{威武}", "{美元}", "{正义}", "{orz}", "{呕吐}", "{大哭}", "{色}", "{左哼}", "{开心}", "{小声}", "{可怜}", "{困}", "{围观}", "{偷笑}", "{害羞}", "{再见}", "{浮云}", "{右哼}", "{星星}", "{鄙视}", "{死宅}", "{神马}", "{给钱}", "{龇牙}", "{勉强}", "{闭嘴}", "{太阳}", "{给力}", "{恼火}", "{加油}", "{胜利}", "{示威}", "{鼓掌}", "{幸福}" };/// List<string> list;
        //  list = new List<string>();
        while (str.Length > 0)
        {
            if (!str.Contains("{"))
                break;
            else
            {
                int start = str.IndexOf('{');
                int end = str.IndexOf('}');
                string tmp = str.Substring(start, end - start + 1);
                int j = 0;
                for (j = 0; j < a.Length; j++)
                {
                    if (a[j].Contains(tmp))
                        break;
                }
                j++;
                str = str.Replace(tmp, "<img src=../express/a" + j + ".gif>");
            }
        }
        return str;

    }
    protected void close_Click(object sender, EventArgs e)
    {
        Response.Write("<script >window.dialogArguments.location.href=window.dialogArguments.location.href;</script>");
        Response.Write("<script>window.close()</script>");
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {

    }
    protected void Timer1_Tick(object sender, EventArgs e)
    {
        int n = Convert.ToInt16(time.Text);
        if(n-1==0)
            Response.Write("<script>window.close()</script>");
        else
        time.Text = Convert.ToString(n-1);

      
    }
}
