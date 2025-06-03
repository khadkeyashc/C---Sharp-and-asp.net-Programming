using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication53
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            string[] name = { "yash", "Tejas", "Milind" };
            string[] code = {"201","454","134"};
            string[] price = { "45677", "35436", "3443534" };
            Response.Write("<table border='2px' align='center' >");
            Response.Write("<tr>");
            Response.Write("<th>ItemName</th>");
            Response.Write("<th>IttemCode</th>");
            Response.Write("<th>ItemPrice</th>");
            Response.Write("</tr>");
            for(int i=0;i<3;i++)
            {
                Response.Write("<tr>");
                Response.Write("<td>" + name[i] + "</td>");
                Response.Write("<td>" + code[i] + "</td>");
                Response.Write("<td>" + price[i] + "</td>");
                Response.Write("</tr>");
            }
            Response.Write("</table");

        }

       
    }
}