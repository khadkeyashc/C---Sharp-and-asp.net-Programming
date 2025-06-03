using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label2.Text = "";
            if(RadioButton1.Checked)
            {
                Label2.Text = "Your Gender is" + RadioButton1.Text;
            }
            else
            {
                Label2.Text = "Your Gender is" + RadioButton2.Text;
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {

        }
    }
}