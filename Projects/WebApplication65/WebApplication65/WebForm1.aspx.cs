using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication65
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = "Student Name Is:" + TextBox1.Text;
            Label2.Text = "Student RollNo Is:" + TextBox2.Text;
            Label3.Text = "Student Branch Is:" + TextBox3.Text;

        }
    }
}