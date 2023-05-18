<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Chapter 11 - Exercise</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
         <h2>Vendor Invoices</h2><br />
        Choose a vendor:&nbsp;&nbsp;
        <asp:DropDownList ID="ddlVendors" runat="server"  Width="250px" AutoPostBack="True">
        </asp:DropDownList>  <br /><br />
      
    </div>
    </form>
</body>
</html>
