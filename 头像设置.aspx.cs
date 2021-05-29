using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
public partial class 头像设置 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Button1.Checked)
        {
            FileUpload1.Visible = true;
            String strConnection = "Provider=Microsoft.Ace.OleDb.12.0; Data Source=" + Server.MapPath("data.mdb");
            OleDbConnection con = new OleDbConnection(strConnection);
            con.Open();
            string order;
            char ch = Convert.ToChar(34);
            order = "select 头像 from people where 用户名= " + ch + Request.Cookies["info"].Values["user"].ToString() + ch + ";";
            OleDbDataAdapter myCommand1 = new OleDbDataAdapter(order, con);

            DataSet ds = new DataSet();          //数据集合
            myCommand1.Fill(ds, "type");
            DataTable dt = new DataTable();        //数据表
            dt = ds.Tables["type"];

            if (!dt.Rows[0][0].ToString().Equals(""))//已经上传头像
            {
                Image1.ImageUrl = dt.Rows[0][0].ToString();
                Image2.ImageUrl = dt.Rows[0][0].ToString();
                Image3.ImageUrl = dt.Rows[0][0].ToString();


            }
            con.Close();
        }
        else
        {
            FileUpload1.Visible = false;

        }
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Label1.Text = "";
        string name = FileUpload1.FileName;
        int size = FileUpload1.PostedFile.ContentLength;
        string type = FileUpload1.PostedFile.ContentType;
        string ipath = Server.MapPath(@"~\image\") + name;
        string dpath;
        dpath = @"~\image\";
        dpath += name;
        if (name.Contains(".jpg") || name.Contains(".JPG") || name.Contains(".PNG") || name.Contains(".png") || name.Contains(".gif") || name.Contains(".GIF"))
        {
            if (size < 1024 * 1014 * 4)
            {
                FileUpload1.SaveAs(ipath);
                Image1.Visible = true;
                Image1.ImageUrl = dpath;
                Image2.Visible = true;
                Image2.ImageUrl = dpath;
                Image3.ImageUrl = dpath;
                Image3.Visible = true;
                String strConnection = "Provider=Microsoft.Ace.OleDb.12.0; Data Source=" + Server.MapPath("data.mdb");
                OleDbConnection con = new OleDbConnection(strConnection);
                con.Open();
                char ch = Convert.ToChar(34);
                string order = "insert into images(用户名,照片,相册,图片上传时间) values(" + ch + Convert.ToString(Request.Cookies["info"].Values["user"]) + ch + "," + ch;
                order += dpath;
                order += ch;
                order += ",";
                order += ch;
                order += "头像相册";
                order += ch;
                order += ",";
                order += ch;
                order += System.DateTime.Now.ToString();
                order += ch;
                order += ");";
                //string order = "insert into images(照片) values("+ch+"qwe"+ch+");";
                //Label1.Text = order;
                OleDbCommand myCommand = new OleDbCommand(order, con);
                myCommand.ExecuteNonQuery();
                con.Close();
                string order1 = "update people set 头像=";
                order1 += ch;
                order1 += dpath;
                order1 += ch;
                order1 += "where 用户名=";
                order1 += ch;
                order1 += Request.Cookies["info"].Values["user"].ToString();
                order1 += ch;
                order1 += ";";
                con.Open();
                OleDbCommand myCommand1 = new OleDbCommand(order1, con);
                myCommand1.ExecuteNonQuery();
                con.Close();
                //   HttpCookie c = new HttpCookie("img");

            }
            else
            {
                Label1.Text="图片过大！请上传小于4MB的图片";
            }
        }
        else
        {
           Label1.Text="请上传正确的图片格式" + name;
        }
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        //response.redirect(request.url.tostring());
        Response.Write("<script type='text/javascript'>window.parent.location.href='我的封面.aspx';</script>");
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        if (!FileUpload1.FileName.Equals(""))
        {
            string ipath = Server.MapPath(@"~\image\") + FileUpload1.FileName;
            Image1.Visible = true;
            Image2.Visible = true;
            Image3.Visible = true;
            Image1.ImageUrl = ipath;
            Image2.ImageUrl = ipath;
            Image3.ImageUrl = ipath;
        }
        else
        {

            Label1.Text = "请选择图片";
        }

    }
}