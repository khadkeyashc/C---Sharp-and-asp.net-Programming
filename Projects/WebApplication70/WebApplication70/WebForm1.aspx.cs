using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication70
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if ((FileUpload1.PostedFile != null) && (FileUpload1.PostedFile.ContentLength > 0))
            {
                string fn = System.IO.Path.GetFileName(FileUpload1.PostedFile.FileName);
                string filesavelocation = @"E:\im" + fn; // Use Server.MapPath for the physical path
                try
                {
                    FileUpload1.PostedFile.SaveAs(filesavelocation);
                    Label1.Text = "File Uploaded Successfully";
                }
                catch (Exception ex)
                {
                    Label1.Text = "Error: " + ex.Message + " File Is Not Uploaded";
                }
            }
            else
            {
                Label1.Text = "Please select a file to upload.";
            }
        }
    }
}