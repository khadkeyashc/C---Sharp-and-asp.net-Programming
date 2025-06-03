using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication29
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DetailsView1_ItemInserted(object sender, DetailsViewInsertedEventArgs e)
        {
            Label1.Text = "Item Inserted Sucessfully";
            GridView1.DataBind();
        }

        protected void GridView1_RowDeleted(object sender, GridViewDeletedEventArgs e)
        {
            Label1.Text = "Item Deleted Sucessfully";
            GridView1.DataBind();
        }

        protected void GridView1_RowUpdated(object sender, GridViewUpdatedEventArgs e)
        {
            Label1.Text = "Item Updated Sucessfully";
            GridView1.DataBind();
        }
    }
}