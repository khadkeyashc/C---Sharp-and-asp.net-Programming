using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication97
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Cookies["username"].Value = TextBox1.Text;
            Response.Cookies["password"].Value = TextBox2.Text;
            Response.Cookies["username"].Expires = DateTime.Now.AddMinutes(1);
            Response.Cookies["password"].Expires=DateTime.Now.AddMinutes(1);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Label1.Text = Request.Cookies["username"].Value;
            Label2.Text = Request.Cookies["password"].Value ;
        }
    }
}