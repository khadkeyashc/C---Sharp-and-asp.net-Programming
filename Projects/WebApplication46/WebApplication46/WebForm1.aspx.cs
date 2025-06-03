using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication46
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Cookies["uname"].Value = TextBox2.Text;
            Response.Cookies["password"].Value = TextBox3.Text;
            Response.Cookies["uname"].Expires = DateTime.Now.AddMinutes(1);
            Response.Cookies["password"].Expires=DateTime.Now.AddMinutes(1);
            Label3.Text = "Cookie Created Sucessfully";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Label1.Text = Request.Cookies["uname"].Value;
            Label2.Text = Request.Cookies["password"].Value;
        }
    }
}