using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
using System.Text.RegularExpressions;
using System.Collections;
using System.Windows;
public partial class 微博页面 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["nowpos"] == null)
                Session["nowpos"] = Request.Cookies["info"].Values["nickname"].ToString();
            char ch = Convert.ToChar(34);
            String strConnection = "Provider=Microsoft.Ace.OleDb.12.0; Data Source=" + Server.MapPath("data.mdb");
            OleDbConnection con = new OleDbConnection(strConnection);
            con.Open();
            string weiboorder;
            if (Session["nowpos"].ToString().Equals(Request.Cookies["info"].Values["nickname"].ToString()))
            {
                weiboorder = "select distinct top 150 people.昵称,people.头像,post.时间,post.原创内容,post.原创,post.转发内容,post.转发总数,post.原创昵称 from [post],[people],[focus] where ( focus.用户昵称='" + Session["nowpos"].ToString() + "'" + " and focus.关注的人=people.昵称 and people.昵称=post.昵称 ) or (post.昵称='" + Session["nowpos"].ToString() + "' and people.昵称=post.昵称 ) order by post.时间 desc";
            }
            else
            {
                weiboorder = "select distinct top 150 people.昵称,people.头像,post.时间,post.原创内容,post.原创,post.转发内容,post.转发总数,post.原创昵称 from [post],[people],[focus] where (post.昵称='" + Session["nowpos"].ToString() + "' and people.昵称=post.昵称 ) order by post.时间 desc";
            }
            //string weiboorder = "select people.昵称,people.头像,postshort.时间 from [postshort],[people],[focus] where focus.关注的人=" + ch + Request.Cookies["info"].Values["user"].ToString() + ch + " and focus.用户名=people.用户名 and people.用户名=postshort.用户名 ";

            OleDbDataAdapter c1 = new OleDbDataAdapter(weiboorder, con);
            DataSet ds = new DataSet();
            c1.Fill(ds, "type");
            DataTable dt = new DataTable();        //数据表
            dt = ds.Tables["type"];
            GridView1.DataSource = ds;
            GridView1.DataBind();
            Session["allweibo"] = ds;
            bind(dt);
            con.Close();
            Session["height"] = GridView1.Height;
        }
        else
        {

        }
    }

    public void bind(DataTable dt)
    {
        String strConnection = "Provider=Microsoft.Ace.OleDb.12.0; Data Source=" + Server.MapPath("data.mdb");
        OleDbConnection con = new OleDbConnection(strConnection);
        con.Open();
        ImageButton m1;
        Label l1, l2, l3, l4;
        Button b1, b2, b3, b4;
        Panel p1, p2;
        LinkButton link1, name1;
        ImageButton more1;

        for (int i = 0; i < GridView1.PageSize && i + GridView1.PageIndex * GridView1.PageSize < dt.Rows.Count; i++)
        {
            more1 = (ImageButton)GridView1.Rows[i].FindControl("more");///举报
            m1 = (ImageButton)GridView1.Rows[i].FindControl("showimg");
            m1.ImageUrl = dt.Rows[i + GridView1.PageIndex * GridView1.PageSize][1].ToString();
            //m1.Visible = true;
            //  
            name1 = (LinkButton)GridView1.Rows[i].FindControl("name");
            // h1.c="text-decoration:none";
            name1.Text = dt.Rows[i + GridView1.PageIndex * GridView1.PageSize][0].ToString();

            l1 = (Label)GridView1.Rows[i].FindControl("posttime");
            string time = dt.Rows[i + GridView1.PageIndex * GridView1.PageSize][2].ToString();
            string today = System.DateTime.Now.ToString("d");
            string[] s = time.Split(' ');
            //string hour = System.DateTime.Now.ToString();
            if (s[0].Equals(today))
            {
                l1.Text = "今天 " + s[1];
            }
            else
            {
                l1.Text = time;
            }
            //l1.Text=
            ///下面的代码用来处理微博内容的显示
            //l4 = (Label)GridView1.Rows[i].FindControl("copy");
            l3 = (Label)GridView1.Rows[i].FindControl("original");
            l2 = (Label)GridView1.Rows[i].FindControl("showpost");
            link1 = (LinkButton)GridView1.Rows[i].FindControl("originalname");
            if (dt.Rows[i + GridView1.PageIndex * GridView1.PageSize][4].ToString() == "1")///原创
            {

                l2.Attributes.Add("style", "display:none");
                // name1.
                link1.Attributes.Add("style", "display:none");
                l3.Text = dt.Rows[i + GridView1.PageIndex * GridView1.PageSize][3].ToString();
                l3.Text = dealimg(l3.Text);
            }
            else
            {
                l2.Text = dt.Rows[i + GridView1.PageIndex * GridView1.PageSize][5].ToString();
                l2.Text = dealimg(l2.Text);
                if (dt.Rows[i + GridView1.PageIndex * GridView1.PageSize][3].ToString() != "")
                {
                    l3.Text = dt.Rows[i + GridView1.PageIndex * GridView1.PageSize][3].ToString();
                    l3.Text = dealimg(l3.Text);
                    link1.Text = dt.Rows[i + GridView1.PageIndex * GridView1.PageSize][7].ToString() + "</br>";
                }
                else
                    l3.Text = "原微博已被删除";
            }

            ////处理未被删除原微博           
            b1 = (Button)GridView1.Rows[i].FindControl("Button11");
            b2 = (Button)GridView1.Rows[i].FindControl("follow");
            if (!dt.Rows[i][6].ToString().Equals("0"))
                b2.Text = "转发  " + dt.Rows[i + GridView1.PageIndex * GridView1.PageSize][6].ToString();
            else
                b2.Text = "转发";
            string findcomment = "";
            if (dt.Rows[i + GridView1.PageIndex * GridView1.PageSize][5].ToString() != "")
                findcomment = "select count(*) from [comment] where 微博内容='" + dt.Rows[i + GridView1.PageIndex * GridView1.PageSize][5].ToString() + "' and 微博用户='" + dt.Rows[i + GridView1.PageIndex * GridView1.PageSize][0].ToString() + "'";
            else
                findcomment = "select count(*) from [comment] where 微博内容='" + dt.Rows[i + GridView1.PageIndex * GridView1.PageSize][3].ToString() + "' and 微博用户='" + dt.Rows[i + GridView1.PageIndex * GridView1.PageSize][0].ToString() + "'";
            OleDbCommand find = new OleDbCommand(findcomment, con);
            int commentc = (int)find.ExecuteScalar();
            b3 = (Button)GridView1.Rows[i].FindControl("comment");
            if (commentc != 0)
                b3.Text = "评论  " + Convert.ToString(commentc);
            else
                b3.Text = "评论";
            if (Request.Cookies["info"].Values["nickname"].ToString().Equals(name1.Text))
            {
                b4 = (Button)GridView1.Rows[i].FindControl("del");
                b4.Text = "删除";
                b4.Visible = true;
            }

        }
        con.Close();

    }
    public string dealimg(string str)///用来处理表情路径
    {
        string[] a = new string[] { "{人}", "{哭泣}", "{亲吻}", "{抽烟}", "{卖萌}", "{发火}", "{可爱}", "{说谎}", "{难过}", "{大笑}", "{委屈}", "{威武}", "{美元}", "{正义}", "{orz}", "{呕吐}", "{大哭}", "{色}", "{左哼}", "{开心}", "{小声}", "{可怜}", "{困}", "{围观}", "{偷笑}", "{害羞}", "{再见}", "{浮云}", "{右哼}", "{星星}", "{鄙视}", "{死宅}", "{神马}", "{给钱}", "{龇牙}", "{勉强}", "{闭嘴}", "{太阳}", "{给力}", "{恼火}", "{加油}", "{胜利}", "{示威}", "{鼓掌}", "{幸福}" };// List<string> list;
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
    public string setimg(string str)
    {
        string[] a = new string[] { "{人}", "{哭泣}", "{亲吻}", "{抽烟}", "{卖萌}", "{发火}", "{可爱}", "{说谎}", "{难过}", "{大笑}", "{委屈}", "{威武}", "{美元}", "{正义}", "{orz}", "{呕吐}", "{大哭}", "{色}", "{左哼}", "{开心}", "{小声}", "{可怜}", "{困}", "{围观}", "{偷笑}", "{害羞}", "{再见}", "{浮云}", "{右哼}", "{星星}", "{鄙视}", "{死宅}", "{神马}", "{给钱}", "{龇牙}", "{勉强}", "{闭嘴}", "{太阳}", "{给力}", "{恼火}","{加油}","{胜利}","{示威}","{鼓掌}","{幸福}" };// List<string> list;
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
    protected void Button11_Click(object sender, EventArgs e)
    {
        int count = ((GridViewRow)((Button)sender).Parent.Parent).RowIndex;
        Label post = (Label)GridView1.Rows[count].FindControl("showpost");
        Label content = (Label)GridView1.Rows[count].FindControl("original");
        LinkButton name = (LinkButton)GridView1.Rows[count].FindControl("name");
        post.Text = setimg(post.Text.Replace("</br>",""));
        content.Text = setimg(content.Text.Replace("</br>",""));
        String strConnection = "Provider=Microsoft.Ace.OleDb.12.0; Data Source=" + Server.MapPath("data.mdb");
        OleDbConnection con = new OleDbConnection(strConnection);
        con.Open();
        int n;
        if (post.Text == "") n = 1;
        else
            n = 0;
        string preord = "select * from [reserve] where 收藏的微博='" + Convert.ToString(post.Text) + "' and 微博用户='" + name.Text + "' and 原创=" + n;
        OleDbCommand pre = new OleDbCommand(preord, con);
        int cnt = 0;
        if (pre.ExecuteScalar() != null)
            cnt = (int)pre.ExecuteScalar();
        if (cnt == 0)
        {
            string reserve = "";
            if (post.Text == "")
                reserve = "insert into [reserve](用户昵称,收藏的微博,收藏时间,微博用户,原创) values('" + Request.Cookies["info"].Values["nickname"].ToString() + "','" + Convert.ToString(content.Text) + "','" + System.DateTime.Now + "','" + name.Text + "',1)";
            else
                reserve = "insert into [reserve](用户昵称,收藏的微博,收藏时间,微博用户,原创) values('" + Request.Cookies["info"].Values["nickname"].ToString() + "','" + Convert.ToString(post.Text) + "','" + System.DateTime.Now + "','" + name.Text + "',0)";
            OleDbCommand o = new OleDbCommand(reserve, con);
            o.ExecuteNonQuery();
        }
        else
        {
            Response.Write("<script>alert('该微博已经被收藏')</script>");
        }
        con.Close();
        post.Text = dealimg(post.Text.Replace("</br>", ""));
        content.Text = dealimg(content.Text.Replace("</br>", ""));
    }
    protected void Button12_Click(object sender, EventArgs e)
    {

        int count = ((GridViewRow)((Button)sender).Parent.Parent).RowIndex;
        Label l1 = (Label)GridView1.Rows[count].FindControl("original");
        LinkButton l3 = (LinkButton)GridView1.Rows[count].FindControl("name");
        LinkButton link1 = (LinkButton)GridView1.Rows[count].FindControl("originalname");
        Session["weibocontent"] = l1.Text;
        if (link1.Text != "")
            Session["ori"] = link1.Text.Replace("</br>", "");///原创的昵称
        else
            Session["ori"] = l3.Text;
        Label l2 = (Label)GridView1.Rows[count].FindControl("showpost");

        Session["weibopost"] = l2.Text;///转发的内容
        Session["nowname"] = l3.Text;
        Response.Write("<script>window.showModelessDialog('转发微博.aspx',window,'dialogHeight:450px;dialogWidth:600px;help:0;center:yes;resizable:0;status:0;scroll:no')</script>");
    }
    protected void Button13_Click(object sender, EventArgs e)
    {
        int count = ((GridViewRow)((Button)sender).Parent.Parent).RowIndex;
        Session["click"] = Convert.ToString(count);
        Panel p;
        GridView g;
        ImageButton img1;
        p = (Panel)GridView1.Rows[count].FindControl("Panel2");
        g = (GridView)GridView1.Rows[count].FindControl("allcomment");
        img1 = (ImageButton)GridView1.Rows[count].FindControl("ImageButton10");
        if(g.Visible&&p.Visible)
        {
            g.Visible = false;
            p.Visible = false;
            return;
        }
        g.Visible = true;
        p.Visible = true;

        //int count = ((GridViewRow)((Button)sender).Parent.Parent).RowIndex;
        Label post = (Label)GridView1.Rows[count].FindControl("showpost");
        Label content = (Label)GridView1.Rows[count].FindControl("original");
        LinkButton name = (LinkButton)GridView1.Rows[count].FindControl("name");
        //   Label tmp1 = (Label)GridView1.Rows[count].FindControl("copy");
        //TextBox t = (TextBox)GridView1.Rows[count].FindControl("TextBox2");
        post.Text = setimg(post.Text.Replace("</br>", ""));
        content.Text = setimg(content.Text.Replace("</br>",""));
        String strConnection = "Provider=Microsoft.Ace.OleDb.12.0; Data Source=" + Server.MapPath("data.mdb");
        OleDbConnection con = new OleDbConnection(strConnection);
        con.Open();
        string findimg = "select 头像 from [people] where 昵称='" + Session["nowpos"].ToString() + "'";
        OleDbCommand d = new OleDbCommand(findimg, con);
        OleDbDataReader r = d.ExecuteReader();
        while (r.Read())
        {
            img1.ImageUrl = r.GetString(0);
            img1.Visible = true;
        }
        string order = "";
        if (post.Text == "")
            order = "select people.头像,comment.评论,comment.发布时间,people.昵称 from [comment],[people] where comment.微博内容='" + content.Text + "' and  微博用户='" + name.Text + "' and comment.昵称=people.昵称 ";
        else
            order = "select people.头像,comment.评论,comment.发布时间,people.昵称 from [comment],[people] where comment.微博内容='" + post.Text + "' and  微博用户='" + name.Text + "' and comment.昵称=people.昵称;";
        OleDbDataAdapter c1 = new OleDbDataAdapter(order, con);
        DataSet ds = new DataSet();
        c1.Fill(ds, "type");
        DataTable dt = new DataTable();        //数据表
        dt = ds.Tables["type"];
        g.DataSource = dt;
        g.DataBind();
        Session["commentds"] = dt;

        commmnetbind(dt, g);
        con.Close();



    }
    public void commmnetbind(DataTable dt, GridView g)
    {
        int count = Convert.ToInt16(Session["click"].ToString());
        Label l1, l2;
        LinkButton link;
        ImageButton i1;
        Button b1;
        //GridView g = (GridView)GridView1.Rows[count].FindControl("allcomment");
        // Response.Write(g.PageIndex + " " + dt.Rows.Count);
        for (int i = 0; i < g.PageSize && i + g.PageIndex * g.PageSize < dt.Rows.Count; i++)
        {
            l1 = (Label)g.Rows[i].FindControl("Label1");
            l2 = (Label)g.Rows[i].FindControl("Label2");
            link = (LinkButton)g.Rows[i].FindControl("name");
            i1 = (ImageButton)g.Rows[i].FindControl("ImageButton8");
            b1 = (Button)g.Rows[i].FindControl("report");
            b1.Visible = true;
            b1.Text = "举报";
            l1.Text = dt.Rows[i + g.PageIndex * g.PageSize][1].ToString();
            l2.Text = dt.Rows[i + g.PageIndex * g.PageSize][2].ToString();
            link.Text = dt.Rows[i + g.PageIndex * g.PageSize][3].ToString();
            i1.ImageUrl = dt.Rows[i + g.PageIndex * g.PageSize][0].ToString();
        }
    }
    protected void Button14_Click(object sender, EventArgs e)
    {
        int count = ((GridViewRow)((Button)sender).Parent.Parent).RowIndex;
        //  Response.Write(str);
        String strConnection = "Provider=Microsoft.Ace.OleDb.12.0; Data Source=" + Server.MapPath("data.mdb");
        OleDbConnection con = new OleDbConnection(strConnection);
        con.Open();
        Label showpost = (Label)GridView1.Rows[count].FindControl("showpost");
        Label ori = (Label)GridView1.Rows[count].FindControl("original");
        LinkButton oriname = (LinkButton)GridView1.Rows[count].FindControl("originalname");
        LinkButton name = (LinkButton)GridView1.Rows[count].FindControl("name");
        // string deleteorder = "";
        showpost.Text = setimg(showpost.Text);
        ori.Text = setimg(ori.Text);
        string updateorder = "";
        string deleteorder = "";
        if (showpost.Text == "")
        {

            deleteorder = "delete  from [post] where 原创内容='" + ori.Text + "' and 昵称='" + name.Text + "' and 原创=1";
            updateorder = "update [post] set 原创内容='',原创昵称='' where 原创内容='" + ori.Text + "' and 昵称='" + name.Text + "' and 原创=0";
            OleDbCommand updatedata = new OleDbCommand(updateorder, con);
            updatedata.ExecuteNonQuery();

        }
        else
        {
            // Response.Write(ori.Text+" "+oriname.Text+" "+name.Text+" "+showpost.Text);
            oriname.Text = oriname.Text.Replace("</br>", "");
            if (ori.Text != "原微博已被删除")
            {
                deleteorder = "delete  from [post] where 原创内容='" + ori.Text + "' and 原创昵称='" + oriname.Text + "' and 昵称='" + name.Text + "' and 原创=0 and 转发内容='" + showpost.Text + "'";
            }
            else
            {
                deleteorder = "delete  from [post] where " + " 昵称='" + name.Text + "' and 原创=0 and 转发内容='" + showpost.Text + "'";
            }
        }
        //    Response.Write(deleteorder);
        OleDbCommand deletedata = new OleDbCommand(deleteorder, con);
        deletedata.ExecuteNonQuery();

        con.Close();
        Response.Write("<script type='text/javascript'>window.parent.location.href=window.parent.location.href;</script>");


        //Response.Write(deleteorder);
    }
    protected void showimg_Click(object sender, ImageClickEventArgs e)
    {
        int count = ((GridViewRow)((ImageButton)sender).Parent.Parent).RowIndex;
        LinkButton link1;
        link1 = (LinkButton)GridView1.Rows[count].FindControl("name");
        Session["nowpos"] = link1.Text;
        Response.Write("<script type='text/javascript'>window.parent.location.href='我的封面.aspx';</script>");
    }
    protected void name_Click(object sender, EventArgs e)
    {
        int count = ((GridViewRow)((ImageButton)sender).Parent.Parent).RowIndex;
        LinkButton link1;
        link1 = (LinkButton)GridView1.Rows[count].FindControl("name");
        // Response.Cookies["info"].(Request.Cookies["info"].Values["nickname"].ToString());
        //Response.Cookies["info"].Values.Set("nowpos", Convert.ToString(link1));
        Session["nowpos"] = link1.Text;
        Response.Write("<script type='text/javascript'>window.parent.parent.location.href='我的封面.aspx';</script>");
    }
    protected void ImageButton8_Click(object sender, ImageClickEventArgs e)
    {
        /* int count1 = ((GridViewRow)((ImageButton)sender).Parent.Parent.Parent.Parent).RowIndex;
         int count2 = ((GridViewRow)((ImageButton)sender).Parent.Parent).RowIndex;
       
         */
        int count1 = ((GridViewRow)((ImageButton)sender).Parent.Parent.Parent.Parent.Parent.Parent).RowIndex;
        int count2 = ((GridViewRow)((ImageButton)sender).Parent.Parent).RowIndex;
        GridView g = (GridView)GridView1.Rows[count1].FindControl("allcomment");
        LinkButton l1;
        l1 = (LinkButton)g.Rows[count2].FindControl("name");
        Session["nowpos"] = l1.Text;
        Response.Write("<script type='text/javascript'>window.parent.location.href=window.parent.location.href;</script>");
    }
    protected void ImageButton9_Click(object sender, ImageClickEventArgs e)
    {

    }
    protected void Button15_Click(object sender, EventArgs e)
    {
        int count = Convert.ToInt16(Session["click"].ToString());
        //Label l1 = (Label)GridView1.Rows[count].FindControl("copy");
        LinkButton oriname = (LinkButton)GridView1.Rows[count].FindControl("originalname");
        LinkButton name = (LinkButton)GridView1.Rows[count].FindControl("name");
        Label post = (Label)GridView1.Rows[count].FindControl("showpost");
        Label content = (Label)GridView1.Rows[count].FindControl("original");
        Label posttime = (Label)GridView1.Rows[count].FindControl("posttime");
        String strConnection = "Provider=Microsoft.Ace.OleDb.12.0; Data Source=" + Server.MapPath("data.mdb");
        OleDbConnection con = new OleDbConnection(strConnection);
        con.Open();

        TextBox t = (TextBox)GridView1.Rows[count].FindControl("TextBox2");
        string order1 = "insert into comment(昵称,发布时间,微博内容,评论,微博用户) values('";
        order1 += Request.Cookies["info"].Values["nickname"].ToString();
        order1 += "','";
        order1 += System.DateTime.Now;
        order1 += "','";
        if (post.Text == "")
            order1 += content.Text;
        else
            order1 += post.Text;
        order1 += "','";
        order1 += t.Text;
        order1 += "','";
        order1 += name.Text;
        order1 += "')";
        // Response.Write(order1);
        OleDbCommand a = new OleDbCommand(order1, con);
        a.ExecuteNonQuery();
        con.Close();
        Response.Write("<script type='text/javascript'>window.parent.location.href=window.parent.location.href</script>");
    }
    protected void name_Click1(object sender, EventArgs e)
    {
        int count = ((GridViewRow)((LinkButton)sender).Parent.Parent).RowIndex;
        LinkButton link1;
        link1 = (LinkButton)GridView1.Rows[count].FindControl("name");
        Session["nowpos"] = link1.Text;
        //  Response.Redirect("我的封面.aspx");
        Response.Write("<script type='text/javascript'>window.parent.location.href='我的封面.aspx';</script>");
    }
    protected void originalname_Click(object sender, EventArgs e)
    {
        int count = ((GridViewRow)((LinkButton)sender).Parent.Parent.Parent.Parent).RowIndex;
        LinkButton link1;
        link1 = (LinkButton)GridView1.Rows[count].FindControl("originalname");
        string[] arr = link1.Text.Split('@');
        // Response.Cookies["info"].(Request.Cookies["info"].Values["nickname"].ToString());
        //  Response.Cookies["info"].Values.Set("nowpos", arr[1]);
        Session["nowpos"] = arr[1];

        Response.Write("<script type='text/javascript'>window.parent.location.href='我的封面.aspx';</script>");
    }
    protected void ImageButton12_Click(object sender, ImageClickEventArgs e)
    {

    }
    protected void ImageButton10_Click(object sender, ImageClickEventArgs e)
    {
        int count = ((GridViewRow)((ImageButton)sender).Parent).RowIndex;
        LinkButton link1;
        link1 = (LinkButton)GridView1.Rows[count].FindControl("name");
        // Response.Cookies["info"].(Request.Cookies["info"].Values["nickname"].ToString());
        // Response.Cookies["info"].Values.Set("nowpos", Convert.ToString(link1.Text));
        Session["nowpos"] = link1.Text;
        //  Response.Redirect("我的封面.aspx");
        Response.Write("<script type='text/javascript'>window.parent.location.href=window.parent.location.href;</script>");
    }
    protected void Button16_Click(object sender, EventArgs e)
    {

    }
    protected void searchbox_TextChanged(object sender, EventArgs e)
    {

    }
    protected void Button17_Click(object sender, EventArgs e)
    {

    }
    protected void ImageButton13_Click(object sender, ImageClickEventArgs e)
    {
        int count = ((GridViewRow)((ImageButton)sender).Parent.Parent).RowIndex;
        LinkButton link = (LinkButton)GridView1.Rows[count].FindControl("name");
        ImageButton m1 = (ImageButton)GridView1.Rows[count].FindControl("showimg");
        Label l1 = (Label)GridView1.Rows[count].FindControl("showpost");
        Label l2 = (Label)GridView1.Rows[count].FindControl("original");
        l1.Text = setimg(l1.Text);
        l2.Text = setimg(l2.Text);
        Session["举报"] = "举报微博";
        Session["头像"] = m1.ImageUrl;
        Session["用户名"] = link.Text;
        if (l1.Text != "")
        {
            Session["内容"] = l1.Text;
            Session["原创"] = 0;
        }
        else
        {
            Session["内容"] = l2.Text;
            Session["原创"] = 1;
        }
        l1.Text = dealimg(l1.Text);
        l2.Text = dealimg(l2.Text);
        Response.Write("<script>window.showModelessDialog('举报页面.aspx',window,'dialogHeight:350px;dialogWidth:600px;help:0;resizable:0;status:0;scroll:no')</script>");
    }
    protected void Button18_Click(object sender, EventArgs e)
    {

    }
    protected void Button19_Click(object sender, EventArgs e)
    {
    }
    protected void Button18_Click1(object sender, EventArgs e)
    {
        int count1 = ((GridViewRow)((Button)sender).Parent.Parent.Parent.Parent.Parent.Parent).RowIndex;
        int count2 = ((GridViewRow)((Button)sender).Parent.Parent).RowIndex;
        //int count = ((GridViewRow)((Button)sender).Parent.Parent).RowIndex;
        GridView g = (GridView)GridView1.Rows[count1].FindControl("allcomment");
        //  Label copy = (Label)GridView1.Rows[count1].FindControl("Label1");
        ImageButton m1 = (ImageButton)g.Rows[count2].FindControl("ImageButton8");
        Label l1 = (Label)g.Rows[count2].FindControl("Label1");
        LinkButton link = (LinkButton)g.Rows[count2].FindControl("name");
        Session["举报"] = "举报评论";
        Session["头像"] = m1.ImageUrl;
        // Session["用户名"] = link.Text;
        // Session["微博"] = copy.Text;
        Session["内容"] = l1.Text;
        Session["用户名"] = link.Text;
        Response.Write("<script>window.showModelessDialog('举报页面.aspx',window,'dialogHeight:350px;dialogWidth:600px;help:0;resizable:0;status:0;scroll:no')</script>");
    }
    protected void name_Click2(object sender, EventArgs e)
    {
        int count1 = ((GridViewRow)((LinkButton)sender).Parent.Parent.Parent.Parent.Parent.Parent).RowIndex;
        int count2 = ((GridViewRow)((LinkButton)sender).Parent.Parent).RowIndex;
        GridView g = (GridView)GridView1.Rows[count1].FindControl("allcomment");
        LinkButton l1;
        l1 = (LinkButton)g.Rows[count2].FindControl("name");
        Session["nowpos"] = l1.Text;
        Response.Write("<script type='text/javascript'>window.parent.location.href='我的封面.aspx';</script>");
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        GridView1.DataSource = Session["allweibo"];
        GridView1.DataBind();
        DataSet ds = (DataSet)Session["allweibo"];
        bind(ds.Tables["type"]);
    }
    protected void allcomment_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
    {


    }
    protected void allcomment_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        int count = Convert.ToInt16(Session["click"].ToString());
        Session["click"] = Convert.ToString(count);
        GridView g;
        g = (GridView)GridView1.Rows[count].FindControl("allcomment");
        g.PageIndex = e.NewPageIndex;
        g.DataSource = Session["commentds"];
        g.DataBind();
        commmnetbind((DataTable)Session["commentds"], g);
    }
    protected void GridView1_Load(object sender, EventArgs e)
    {

    }
}