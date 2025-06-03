using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication88
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int count = 0;
            if (Application["myvalue"]!=null)
            {
                count = Convert.ToInt32(Application["myvalue"].ToString());

            }
            count = count + 1;
            Label1.Text = count.ToString();
            Application["myvalue"] = count.ToString();

        }
    }
}