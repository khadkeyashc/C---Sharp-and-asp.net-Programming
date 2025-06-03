using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication16
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "None";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var message = "";
            if(CheckBox2.Checked)
            {
                message = CheckBox1.Text;
            }
            if(CheckBox3.Checked)
            {
                message+= CheckBox2.Text;

            }
            if(CheckBox4.Checked)
            {
                message += CheckBox3.Text;
            }
            Label1.Text = message;
        }
    }
}