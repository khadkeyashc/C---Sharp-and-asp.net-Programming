using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication54
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string[] name = {"Yash","Milind","Tejas","Manoj"};
            string[] code = { "4656", "56", "588", "885" };
            string[] price = { "2000", "70000", "89000", "87450" };
            Response.Write("<table  border='4px' align='center'>");
            Response.Write("<tr>");
            Response.Write("<th>ItemName</th>");
            Response.Write("<th>ItemCode</th>");
            Response.Write("<th>ItemPrice</th>");
            Response.Write("</tr>");
            for(int i=0;i<name.Length;i++)
            {
                Response.Write("<tr>");
                Response.Write("<td>"+name[i]+"</td>");
                Response.Write("<td>"+code[i]+"</td>");
                Response.Write("<td>"+price[i]+"</td>");
                Response.Write("</td>");
            }
            Response.Write("</table>");

        }
    }
}