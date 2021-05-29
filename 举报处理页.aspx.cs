using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
public partial class 举报处理页 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //Response.Write(Session["用户"].ToString()+" "+Request.Cookies["info"].Values["nickname"].ToString());
        //    Response.Write(Session["time"].ToString());
            
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        String strConnection = "Provider=Microsoft.Ace.OleDb.12.0; Data Source=" + Server.MapPath("data.mdb");
        OleDbConnection con = new OleDbConnection(strConnection);
        con.Open();
        string order = "";
        string order1 = "";
        string order2 = "";
        bool flag = false;
        if (RadioButtonList1.SelectedValue == "暂时封掉被举报用户账户")
        {
            order = "insert into blacklist(用户昵称,处罚结束时间) values('" + Session["用户"].ToString() + "','" + System.DateTime.Now.AddDays(Convert.ToInt16(DropDownList1.SelectedValue)) + "')";
            flag = true;
        }
        else if (RadioButtonList1.SelectedValue == "永久封掉被举报用户账户")
        {
            order = "insert into blacklist(用户昵称,处罚结束时间) values('" + Session["用户"].ToString() + "','"+System.DateTime.MaxValue+"')";
            flag = true;
        }
        if (flag)
        {
            order1 = "update people set 封号=1 where 昵称='" + Session["用户"].ToString() + "'";
            order2 = "update "+Session["table"].ToString() +" set 封号=1,处理=1,处理人='"+Request.Cookies["info"].Values["nickname"].ToString()+"' where 举报用户='" + Session["用户"].ToString() + "' and 举报时间='"+Session["time"].ToString()+"'";
            if (Session["table"].ToString() == "reportpeople")
            {
                string order3 = "update reportpeople  set 封号=1,处理=1,处理人='"+Request.Cookies["info"].Values["nickname"].ToString()+"' where 举报用户='"+Session["用户"].ToString()+"' ";
                OleDbCommand o3 = new OleDbCommand(order3,con);
                o3.ExecuteNonQuery();
            }
            OleDbCommand o = new OleDbCommand(order, con);
            o.ExecuteNonQuery();
            OleDbCommand o1 = new OleDbCommand(order1, con);
            o1.ExecuteNonQuery();
            OleDbCommand o2 = new OleDbCommand(order2, con);
            o2.ExecuteNonQuery();
            con.Close();
        }
        Panel1.Visible = false;
        Panel2.Visible = true;
    }
    protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (RadioButtonList1.SelectedValue == "暂时封掉被举报用户账户")
        {
            Panel3.Visible = true;
        }
    }
    protected void Timer1_DataBinding(object sender, EventArgs e)
    {

    }
    protected void Timer1_Tick(object sender, EventArgs e)
    {
        Response.Write("<script >window.dialogArguments.location.href=window.dialogArguments.location.href;</script>");
        Response.Write("<script>window.close()</script>");
    }
}