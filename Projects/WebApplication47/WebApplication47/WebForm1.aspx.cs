using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication47
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Cookies["Uname"].Value = TextBox1.Text;
            Response.Cookies["password"].Value = TextBox3.Text;
            Response.Cookies["Uname"].Expires = DateTime.Now.AddMinutes(1);
            Response.Cookies["Uname"].Expires = DateTime.Now.AddMinutes(1);
            Label1.Text = "Cookie Created";

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Label2.Text = Request.Cookies["Uname"].Value;
            Label3.Text = Request.Cookies["password"].Value;

        }
    }
}