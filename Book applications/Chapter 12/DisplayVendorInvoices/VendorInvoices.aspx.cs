using System;
//using System.Collections.Generic;
//using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class VendorInvoices : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
          if (Session["VendorID"] != null)

             //  if(!string.IsNullOrEmpty(Session["VendorID"].ToString()))
                    {
                // Redisplay the invoices for the previously selected vendor
                 ddlVendors.SelectedValue = Session["VendorID"].ToString();
            
            }
        }
    }


 protected void grdInvoices_RowCommand(object sender, GridViewCommandEventArgs e)
 {
     if (e.CommandName == "ViewLineItems")
     {

         // Get the index of the row with the button that was clicked
         int rowIndex = Convert.ToInt32(e.CommandArgument);

         // Get the key value for the row
        int invoiceID = Convert.ToInt32(grdInvoices.DataKeys[rowIndex].Value);
                 
         // Get the value in the second cell of the row
         GridViewRow row = grdInvoices.Rows[rowIndex];
         TableCell cell = row.Cells[1];
         string invoiceNo = cell.Text;

         Session["InvoiceID"] = invoiceID;
         Session["InvoiceNo"] = invoiceNo;
         Session["VendorID"] = ddlVendors.SelectedValue;
         Session["VendorName"] = ddlVendors.SelectedItem.Text;
         Response.Redirect("LineItems.aspx");
     }
 }

 private void Page_Error(object sender, EventArgs e)
 {
     Exception ex = Server.GetLastError();
     Session["Exception"] = ex;
     Response.Redirect("ErrorPage.aspx");
 }

}