using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication105
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String[] name = {"Yash","Milind","Loki" };
            String[] code = {"201","654","897" };
            String[] Price = {"2000","620000","890000"};
            Response.Write("<table border='2px' align='center'>");
            Response.Write("<tr>");
            Response.Write("<th>ItemName</th>");
             Response.Write("<th>ItemCode</th>");
            Response.Write("<th>ItemPrice</th>");
            Response.Write("</tr>");
            for (int i=0;i<3;i++)
            {
                Response.Write("<tr>");
                Response.Write("<td>" + name[i] + "</td>");
                Response.Write("<td>" + code[i] + "</td>");
                Response.Write("<td>" + Price[i] + "</td>");
                Response.Write("</tr>");
            }
            
           
            Response.Write("</table>");
        }
    }
}