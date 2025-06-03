using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication50
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
    }
}