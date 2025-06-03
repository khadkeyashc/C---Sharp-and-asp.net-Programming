using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication49
{
    public partial class Welcome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"]==null)
            {
                Response.Redirect("login.aspx");
            }
            else
            {
                Label1.Text = Session["username"].ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Protected.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Logout.aspx");
        }
    }
}