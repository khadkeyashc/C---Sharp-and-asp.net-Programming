﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication28
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Your ip Address is" + Request.UserHostAddress);
            Response.Write("<br/>");
            Response.Write("Url of the Page you Are visiting is:" + Request.Url.ToString());
            Response.Write("<br/>");

            Response.Write("Computer name:" + Environment.MachineName);

        }
    }
}