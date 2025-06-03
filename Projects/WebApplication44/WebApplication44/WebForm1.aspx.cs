using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication44
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
                String fn = System.IO.Path.GetFileName(FileUpload1.PostedFile.FileName);
                String fileSaveLocation = @"E:\\im\\" + fn;

                try
                {
                    FileUpload1.PostedFile.SaveAs(fileSaveLocation);
                    Label1.Text = "FileUploaded Sucessfully";
                }

                catch (Exception ex)
                {
                    Label1.Text = ex.Message;

                }
            }

        }
    }
}