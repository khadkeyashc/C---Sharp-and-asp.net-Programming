using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication86
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int count = 0;
            if (Application["pagecount"]!=null)
            {
                count = Int32.Parse(Application["pagecount"].ToString());
                   
            }
            count = count + 1;
            Label1.Text = count.ToString();
            Application["pagecount"] = count.ToString();


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ViewState["myvalue"] = TextBox1.Text;
            TextBox1.Text = String.Empty;

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = ViewState["myvalue"].ToString();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Cookies["username"].Value = TextBox2.Text;
            Response.Cookies["password"].Value= TextBox3.Text;
            Response.Cookies["username"].Expires = DateTime.Now.AddMinutes(1);
            Response.Cookies["password"].Expires = DateTime.Now.AddMinutes(1);
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Label2.Text = Request.Cookies["username"].Value;
            Label3.Text = Request.Cookies["password"].Value;
        }
    }
}