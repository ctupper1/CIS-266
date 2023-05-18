using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{    
    protected void dvVendor_ItemDeleted(object sender, DetailsViewDeletedEventArgs e)
    {
        if (e.Exception != null)
        {
            lblError.Text = "An exception occurred. " + e.Exception.Message;
        }
        else if (e.AffectedRows == 0)
        {
            lblError.Text = "Another user has updated or deleted " + "that vendor. Please try again.";
        }
        else
        {
            grdVendors.DataBind();
        }
    }
    
    protected void dvVendor_ItemInserted(object sender, DetailsViewInsertedEventArgs e)
    {
        if (e.Exception != null)
        {
            lblError.Text = "An exception occurred. " + e.Exception.Message;
            e.ExceptionHandled = true;
        }
        else
        {
            grdVendors.DataBind();
        }
    }
    
    protected void dvVendor_ItemUpdated(object sender, DetailsViewUpdatedEventArgs e)
    {
        if (e.Exception != null)
        {
            lblError.Text = "An exception occurred. " + e.Exception.Message;
            e.ExceptionHandled = true;
            e.KeepInEditMode = true;
        }
        else if (e.AffectedRows == 0)
        {
            lblError.Text = "Another user has updated or deleted that vendor. " + "Please try again.";
        }
        else
        {
            grdVendors.DataBind();
        }
    }

    private void Page_Error(object sender, EventArgs e)
    {
        Exception ex = Server.GetLastError();
        Session["Exception"] = ex;
        Response.Redirect("ErrorPage.aspx");
    }
}