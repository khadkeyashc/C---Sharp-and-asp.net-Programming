using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication31
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Ip Address Is:" + Request.UserHostAddress);
            Response.Write("<br/>");
            Response.Write("The Url Is"+Request.Url.ToString());
            Response.Write("<br/>");
            Response.Write("Your Computer Name is:"+Environment.MachineName);
        }
    }
}