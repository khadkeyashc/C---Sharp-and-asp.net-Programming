using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication105
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("Your ip Address Is:" + Request.UserHostAddress);
            Response.Write("<br/>");
            Response.Write("Your Current Url Is:" + Request.Url.ToString());
             Response.Write("<br/>");
            Response.Write("Your Local Machine Name Is:" + Environment.MachineName);
            Response.Write("<br/>");
            Response.Write("Your Cookies are:"+Request.Cookies);
        }
    }
}