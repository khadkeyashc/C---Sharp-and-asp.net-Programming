using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication49
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(TextBox2.Text.ToString()=="computer")
            {
                Session["username"] = TextBox1.Text.ToString();
                Label1.Text = "Login Sucessfull";
                Response.Redirect("Welcome.aspx");
            }
            else
            {
                {
                    Label1.Text = "Incorrct Password";
                    Response.Redirect("login.aspx");
                }
            }
        }
    }
}