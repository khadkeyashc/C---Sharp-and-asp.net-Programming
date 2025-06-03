using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication36
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = "Welcome" + TextBox1.Text;
            Response.Write("Your Ip Address Is:" + Request.UserHostAddress);
            Response.Write("<br/>");
            Response.Write("The Current url Is:" + Request.Url.ToString());
            Response.Write("<br/>");
            Response.Write("The Name Of Your Desktop Is:" + Environment.MachineName);
        }
    }
}