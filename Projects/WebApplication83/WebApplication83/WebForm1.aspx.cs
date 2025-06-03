using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication83
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           // ViewState["myvalue"] = TextBox1.Text;

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
    }
}