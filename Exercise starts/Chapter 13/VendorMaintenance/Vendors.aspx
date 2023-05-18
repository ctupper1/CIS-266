<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Vendors.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Vendor Maintenance</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h4>Select a Vendor :<asp:DropDownList ID="ddlVendors" runat="server" 
            AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="Name" 
            DataValueField="VendorID">
        </asp:DropDownList>
        </h4>
        <br />
    <br />
    </div>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:PayablesConnectionString %>" 
        SelectCommand="SELECT [VendorID], [Name] FROM [Vendors] ORDER BY [Name]">
    </asp:SqlDataSource>
  
    <br />
    <br />
      <asp:Label ID="lblMessage" runat="server" Text=" "></asp:Label>
    </form>
</body>
</html>

