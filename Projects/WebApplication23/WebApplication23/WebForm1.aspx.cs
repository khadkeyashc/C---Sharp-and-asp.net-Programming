using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication23
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

           
            TextBox1.Text = Calendar1.SelectedDate.ToString("D");
            Calendar1.Visible = false;
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {

            Calendar1.Visible = true;

        }
    }
}