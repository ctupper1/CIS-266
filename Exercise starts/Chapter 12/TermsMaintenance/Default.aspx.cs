using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        SqlDataSource1.InsertParameters["Description"].DefaultValue = txtDescription.Text;
        SqlDataSource1.InsertParameters["DueDays"].DefaultValue = txtDueDays.Text;
        try
        {
            SqlDataSource1.Insert();
            txtDescription.Text = "";
            txtDueDays.Text = "";
        }
        catch (Exception ex)
        {
            lblError.Text = "An exception occurred. " + ex.Message;
        }
    }

  
    protected void Page_Error(object sender, System.EventArgs e)
    {
        Exception ex = null;
        ex = Server.GetLastError();
        Session["Exception"] = ex;
        Response.Redirect("ErrorPage.aspx");
    } }