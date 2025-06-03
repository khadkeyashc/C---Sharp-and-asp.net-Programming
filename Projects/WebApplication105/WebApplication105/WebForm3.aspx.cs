using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication105
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            foreach(ListItem item in CheckBoxList1.Items)
            {
                if(item.Selected==true)
                {
                    Label1.Text+= item.Text.ToString()+"<br/>";
                    

                }

            }
        }
    }
}