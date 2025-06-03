using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication97
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String[] name = {"Yash","Milind","tejas","Loki" };
            String[] code = { "2012", "2103", "5897", "8974" };
            String[] price = { "20000", "40000", "60000", "90000" };
            Response.Write("<table border='2px'  align='center'>");
            Response.Write("<tr>");
            Response.Write("<th>Itemname</th>");
            Response.Write("<th>ItemCode</th>");
            Response.Write("<th>ItemPrice");
            Response.Write("</tr>");
            for(int i=0;i<3;i++)
            {
                Response.Write("<tr>");
                Response.Write("<td>" + name[i] + "</td>");
                Response.Write("<td>" + code[i] + "</td>");
                Response.Write("<td>" + price[i] + "</td>");
                Response.Write("</tr>");
            }
            Response.Write("</table>");
            Response.End();
        }
    }
}