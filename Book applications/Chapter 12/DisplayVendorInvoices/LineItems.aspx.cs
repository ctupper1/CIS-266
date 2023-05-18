using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class LineItems : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        {
            string name = Session["VendorName"].ToString();
            txtVendor.Text = name;
            string invoiceNo = Session["InvoiceNo"].ToString();
            txtInvoiceNo.Text = invoiceNo;
        }
    }

    protected void btnReturn_Click(object sender, EventArgs e)
    {
        Response.Redirect("VendorInvoices.aspx");
    }

    protected void Page_Error(object sender, System.EventArgs e)
    {
        Exception ex = null;
        ex = Server.GetLastError();
        Session["Exception"] = ex;
        Response.Redirect("ErrorPage.aspx");
    }

}