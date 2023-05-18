<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Vendors DataGrid</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h3>Vendor Information (First 10)</h3>
        <h3>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                DataSourceID="XmlDataSource1">
                <Columns>
                    <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                    <asp:BoundField DataField="Address1" HeaderText="Address1" 
                        SortExpression="Address1" />
                    <asp:BoundField DataField="City" HeaderText="City" SortExpression="City" />
                    <asp:BoundField DataField="State" HeaderText="State" SortExpression="State" />
                    <asp:BoundField DataField="ZipCode" HeaderText="ZipCode" 
                        SortExpression="ZipCode" />
                </Columns>
            </asp:GridView>
        </h3>
    </div>
    <asp:XmlDataSource ID="XmlDataSource1" runat="server" 
        DataFile="~/App_Data/VendorsTopTen.xml" 
        TransformFile="~/App_Data/VendorsTransform.xsl"></asp:XmlDataSource>
    </form>
</body>
</html>
