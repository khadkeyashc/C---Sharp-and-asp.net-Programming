using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication81
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // Response.Write("Yash Khadke");
            string[] name = { "yash", "Milind", "Tejas", "Loki" };
            string[] code = { "2012", "2048", "9845", "9578" };
            string[] price = { "200000", "89000", "890000", "98657" };
            Response.Write("<table border='2px' align='center'>");
             Response.Write("<tr>");
            Response.Write("<th>name</th>");
            Response.Write("<th>code</th>");
            Response.Write("<th>price</th>");
            Response.Write("</tr>");
            
            for(int i=0;i<=3;i++)
            {
                Response.Write("<tr>");
                Response.Write("<td>"+name[i]+"</td>");
                Response.Write("<td>"+code[i]+"</td>");
                Response.Write("<td>" + price[i] + "</td>");
                Response.Write("</tr>");
            }
           
            Response.Write("</table>");
        }
    }
}