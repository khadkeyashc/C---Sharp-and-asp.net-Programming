using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication82
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string[] name = {"yash","ritik","manoj","tushar" };
            string[] code = {"34", "56", "76", "67" };
            string[] price = {"20000", "40000", "60000", "80000" };
            Response.Write("<table border='2px'  align='center'>");
            Response.Write("<tr>");
            Response.Write("<th>ItemName</th>");
            Response.Write("<th>ItemCode</th>");
            Response.Write("<th>ItemPrice</th>");
            Response.Write("</tr>");
            for(int i=0;i<=3;i++)
            {
                Response.Write("<tr>");
                Response.Write("<td>" + name[i] +"</td>");
                Response.Write("<td>" + code[i] + "</td>");
                Response.Write("<td>" + price[i] + "</td>");
                Response.Write("</tr>");

            }

        }
    }
}