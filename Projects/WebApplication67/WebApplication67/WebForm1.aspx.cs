﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication67
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        
        }
        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            // For simplicity, let's use hardcoded credentials
            string username = "user";
            string password = "password";

            if (Login.UserName == username && Login1.Password == password)
            {
                // Authentication successful
                FormsAuthentication.RedirectFromLoginPage(Login1.UserName, Login1.RememberMeSet);
            }
            else
            {
                // Authentication failed
                e.Authenticated = false;
            }
        }
    }
}