using System;


public partial class _Default : System.Web.UI.Page
{
    protected void Page_Error(object sender, System.EventArgs e)
    {
        Exception ex = null;
        ex = Server.GetLastError();
        Session["Exception"] = ex;
        Response.Redirect("ErrorPage.aspx");
    }
}