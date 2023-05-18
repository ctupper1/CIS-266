using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    
    protected void DetailsView1_ItemInserted(object sender, DetailsViewInsertedEventArgs e)
    {
        if (e.Exception != null)
        {
            lblMessage.Text = "An exception occurred. " + e.Exception.Message;
            e.ExceptionHandled = true;
        }
        else
        {
            lblMessage.Text = "New vendor successfully added. ";
            ddlVendors.DataBind();
        }

    }
}