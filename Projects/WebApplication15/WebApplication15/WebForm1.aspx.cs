﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication15
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
             if(RadioButton1.Checked)
            {
                Label1.Text = "Your Gender Is:" + RadioButton1.Text;
            }
             else
            {
                Label1.Text = "Your Gender Is:" + RadioButton2.Text;
            }
        }
    }
}