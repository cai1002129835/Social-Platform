using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Drawing.Design;
using System.Drawing;
public partial class test : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //   Label2.Text = System.DateTime.Now.ToString();
       
    }
    public string PictureSwap(string str)
    {
        string[] a = new string[] { "[-_-]", "[@o@]", "[-|-]", "[o_o]", "[ToT]", "[*_*]", "[-x-]", "[-_-zz]", "[t_t]", "[-_-!]", "[:,]", "[:P]", "[:D]", "[:)]", "[:(]", "[:O]", "[:#]", "[:Z]", "[:0=]", "[/:P]", "[:$]", "[-.-]", "[/-_-]", "[:{]", "[zz]", "[|-_-|]", "[-_-||]", "[:.]", "[:-Q]", "[9_9]", "[:,.]", "[:?]", "[:-|]", "[:K]", "[:G]", "[:L]", "[:c]", "[:q]", "[:Y]", "[/gs]", "[/sg]", "[/hp]", "[/ok]", "[/rain]", "[/yin]" };
        for (int i = 1; i <= 45; i++)
        {
            str = str.Replace(a[i - 1], "<img src='../express/a" + i + ".gif' width='20' height='20'/>");

        }
        Response.Write(str + "asadadadad<br/>");
        return str;
    }

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
       
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
       
    }
    public void bind()
    {
        

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        //Label1.Text = System.DateTime.Now.ToString();
    }
    protected void Button1_Click1(object sender, EventArgs e)
    {

    }
    protected void Timer1_Tick(object sender, EventArgs e)
    {
      
    }
  

    protected void ChangeCode_Click(object sender, EventArgs e)
    {

    }
}