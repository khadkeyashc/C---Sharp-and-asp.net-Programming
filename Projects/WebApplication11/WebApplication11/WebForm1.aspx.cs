using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication11
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if((FileUpload1.PostedFile !=null) && (FileUpload1.PostedFile.ContentLength>0))
            {
                String fileup = System.IO.Path.GetFileName(FileUpload1.FileName);
                string SaveLocation = @"F:\\img5\" + fileup;
                try
                {
                    FileUpload1.PostedFile.SaveAs(SaveLocation);
                    Label1.Text = "File Uploaded Sucessfully";
                }
                catch (Exception ex) {
                    Label1.Text = "Error" + ex.Message;
                
                }
                    
                
                    
            }
        }
    }
}