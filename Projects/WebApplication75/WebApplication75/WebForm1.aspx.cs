using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication75
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int var;
        }

       

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(RadioButton1.Checked==true)
            {
                Label1.Text = "Male";
            }
            else if(RadioButton2.Checked==true)
            {
                Label1.Text = "Female";
            }
            else if(RadioButton3.Checked==true)
            {
                Label1.Text = "Other";
            }
            else
            {
                Label1.Text = "Select Your Gender";
            }
           
            }

        }

      
    }
