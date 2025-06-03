using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication48
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(TextBox2.Text.ToString()=="computer")
            {
                Session["username"] = TextBox1.Text.ToString();
                Response.Redirect("Welcome.aspx");
            }
            else
            {
                Label1.Text = "Wrong Password";
            }
        }
    }
}