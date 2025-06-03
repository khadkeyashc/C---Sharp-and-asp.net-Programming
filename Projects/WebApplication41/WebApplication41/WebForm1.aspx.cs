using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace WebApplication41
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Set initial values or perform actions when the page loads for the first time.
            }
        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string selectedOption = ddlOptions.SelectedItem.Text;
            lblResult.Text = "Hello, " + name + "! You selected: " + selectedOption;
        }
    }
}
