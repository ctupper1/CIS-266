<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ErrorPage.aspx.cs" Inherits="ErrorPage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" 
    "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>Chapter 11: Display Vendor Invoices</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h2>Unexpected error</h2><br />
        The following error has occurred:
        <asp:Label ID="lblError" runat="server" 
            ForeColor="Red"></asp:Label></div>
    </form>
</body>
</html>

