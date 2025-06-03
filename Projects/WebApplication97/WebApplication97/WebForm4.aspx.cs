using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication97
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("Your Ip Address is:" + Request.UserHostAddress);
            Response.Write("<br/>");
            Response.Write("Your Current Url Is:" + Request.Url.ToString());
            Response.Write("<br/>");
            Response.Write("your Local MachineName Is:" + Environment.MachineName);

        }
    }
}