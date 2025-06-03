using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication99
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(RadioButton1.Checked)
            {
                Label1.Text = "Male";
            }
            else if(RadioButton2.Checked)
                {
                Label1.Text = "FeMale";

            }
            else
            {
                Label1.Text = "Other";
            }
        }
    }
}