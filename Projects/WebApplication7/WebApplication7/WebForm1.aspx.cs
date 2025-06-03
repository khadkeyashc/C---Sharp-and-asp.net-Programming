using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication7
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if((fu.PostedFile!=null) &&(fu.PostedFile.ContentLength>0))
            {
                string filename = System.IO.Path.GetFileName(fu.PostedFile.FileName);
                string SaveLocation = @"C:\Users\YASH\source\repos\WebApplication7\WebApplication7\img" + filename;
                fu.PostedFile.SaveAs(SaveLocation);
                Label1.Text = "file upload";
            }
        }
    }
}