using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
using System.Text.RegularExpressions;
public partial class 发现 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
          //  string selectmytopic = "select 话题名";
            maincontent.Src = "微博排行榜";
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        maincontent.Src = "微博排行榜";
    }
}