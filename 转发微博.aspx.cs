using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;
using System.Data;
using System.Data.OleDb;
public partial class 转发微博 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Label1.Text = "@" + Session["ori"].ToString() + ":" + Session["weibocontent"].ToString().Replace("</br>", "");
            Label1.Text = setimg(Label1.Text);
            if (Session["weibopost"].ToString().Equals(""))
            {
               

            }
            else
            {
                TextBox1.Text = "//";
                TextBox1.Text += "@";
                TextBox1.Text += Session["nowname"].ToString();
                TextBox1.Text += " :";
                TextBox1.Text += Session["weibopost"];
                TextBox1.Text = setimg(TextBox1.Text);
                Session["pre"] = TextBox1.Text;
                //   TextBox1.Text += "???????";
              
            }
            string s = TextBox1.Text.Replace("</br>", "");
            TextBox1.Text = s;
        }
    }
    public string setimg(string str)
    {

        string[] a = new string[] { "{人}", "{哭泣}", "{亲吻}", "{抽烟}", "{卖萌}", "{发火}", "{可爱}", "{说谎}", "{难过}", "{大笑}", "{委屈}", "{威武}", "{美元}", "{正义}", "{orz}", "{呕吐}", "{大哭}", "{色}", "{左哼}", "{开心}", "{小声}", "{可怜}", "{困}", "{围观}", "{偷笑}", "{害羞}", "{再见}", "{浮云}", "{右哼}", "{星星}", "{鄙视}", "{死宅}", "{神马}", "{给钱}", "{龇牙}", "{勉强}", "{闭嘴}", "{太阳}", "{给力}", "{恼火}", "{加油}", "{胜利}", "{示威}", "{鼓掌}", "{幸福}" };
        //  list = new List<string>();
        while (str.Length > 0)
        {
            if (!str.Contains("<img src=../express/a"))
                break;
            else
            {
                string s = "<img src=../express/a";
                int start = str.IndexOf(s);
                string tmp = str.Substring(start + s.Length, 2);
                int j = 0;
                if (tmp[1] == '.')
                {
                    string final;
                    final = tmp.Substring(0, 1);
                    j = Convert.ToInt16(final);
                }
                else
                    j = Convert.ToInt16(tmp);
                s += j;
                s += ".gif>";
                str = str.Replace(s, a[j - 1]);
            }
        }
        return str;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

    }
    protected void Button1_Click1(object sender, EventArgs e)
    {
        //  Label2.Text = TextBox1.Text;
        if (TextBox1.Text.Length + Label1.Text.Length > 140)
        {
            Label3.Visible = true;
            Panel1.Visible = false;
            return;
        }
        if (TextBox1.Text == "")
            TextBox1.Text = "转发微博";
        Session["weibocontent"] = setimg(Session["weibocontent"].ToString().Replace("</br>",""));
        string order = "insert into post(时间,昵称,转发总数,最后修改时间,昨天转发总数,原创,原创内容,转发内容,原创昵称) values('";
        order += System.DateTime.Now;
        order += "','";
        order += Request.Cookies["info"].Values["nickname"].ToString();
        order += "',0,'";
        order += System.DateTime.Now;
        order += "',0,0,'";
        order += Session["weibocontent"].ToString();
        order += "','";
        order += TextBox1.Text;
        order += "','";
        order += Session["ori"].ToString();
        order += "')";
        String strConnection = "Provider=Microsoft.Ace.OleDb.12.0; Data Source=" + Server.MapPath("data.mdb");
        OleDbConnection con = new OleDbConnection(strConnection);
        con.Open();
        OleDbCommand a = new OleDbCommand(order, con);
        a.ExecuteNonQuery();


        string pre = "";
        if (Session["weibopost"].ToString() != "")
            pre = "select 最后修改时间  from [post] where 昵称='" + Session["nowname"].ToString() + "' and 转发内容='" + Session["weibopost"].ToString() + "' and 原创内容='" + Session["weibocontent"].ToString() + "' and 原创昵称='"+Session["ori"].ToString()+"'";
        else
            pre = "select 最后修改时间  from [post] where 昵称='" + Session["nowname"].ToString() + "' and 原创内容='"+Session["weibocontent"].ToString()+"' and 原创=1";
        OleDbCommand timecompare = new OleDbCommand(pre, con);
        OleDbDataReader timereader = timecompare.ExecuteReader();
        bool flag = true;
        while (timereader.Read())
        {
            if (timereader.GetDateTime(0).Year == System.DateTime.Now.Year && timereader.GetDateTime(0).DayOfYear == System.DateTime.Now.DayOfYear)
                flag = false;
        }
        string changeorder = "update  post set ";
        if (flag)
        {
            ///需要修改上周转发总数
            if (Session["weibopost"].ToString() != "")
            {
                changeorder += ("昨天转发总数=转发总数-昨天转发总数," + "转发总数=转发总数+1,最后修改时间='" + System.DateTime.Now + "' where 昵称='");
                changeorder += Session["nowname"].ToString();
                changeorder += "' and 转发内容='";
                changeorder += Session["weibopost"].ToString();
                changeorder += "' and 原创内容='";
                changeorder += Session["weibocontent"].ToString();
                changeorder += "' and 原创昵称='";
                changeorder += Session["ori"].ToString();
                changeorder += "'";
            }
            else
            {
                changeorder += ("昨天转发总数=转发总数-昨天转发总数," + "转发总数=转发总数+1,最后修改时间='" + System.DateTime.Now + "' where 昵称='");
                changeorder += Session["nowname"].ToString();
                changeorder += "' and 原创内容='";
                changeorder += Session["weibocontent"].ToString();
                changeorder += "' and 原创=1";
            }
        }
        else
        {
            ///不需要修改
            if (Session["weibopost"].ToString() != "")
            {
                changeorder += ("转发总数=转发总数+1,最后修改时间='" + System.DateTime.Now + "' where 昵称='");
                changeorder += Session["nowname"].ToString();
                changeorder += "' and 转发内容='";
                changeorder += Session["weibopost"].ToString();
                changeorder += "' and 原创内容='";
                changeorder += Session["weibocontent"].ToString();
                changeorder += "' and 原创昵称='";
                changeorder += Session["ori"].ToString();
                changeorder += "' and 原创=0";
            }
            else
            {
                changeorder += ("转发总数=转发总数+1,最后修改时间='" + System.DateTime.Now + "' where 昵称='");
                changeorder += Session["nowname"].ToString();
                changeorder += "' and 原创内容='";
                changeorder += Session["weibocontent"].ToString();
                changeorder += "' and 原创=1";
            }
        }
      //  Response.Write(changeorder);
       OleDbCommand a1 = new OleDbCommand(changeorder, con);
        a1.ExecuteNonQuery();
        con.Close();
        // Response.Write("<script type='text/javascript'>window.parent.location.href='Defaul2.aspx';</script>");
        Response.Write("<script >window.dialogArguments.location.href=window.dialogArguments.location.href;</script>");
        Response.Write("<script>window.close()</script>");
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        if (this.Panel1.Visible)
            this.Panel1.Visible = false;
        else
        {

            this.Panel1.Visible = true;
        }
    }
}