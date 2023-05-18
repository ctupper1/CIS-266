<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Exercise 14-2: Display Vendors With Paging</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h2>Vendors Pages</h2>
        <asp:GridView ID="grdVendors" runat="server"  
          AutoGenerateColumns="False" CellPadding="4" CellSpacing="3" 
          ForeColor="#333333" GridLines="None"  >
          <AlternatingRowStyle BackColor="White" />
          <Columns>
            <asp:BoundField DataField="VendorID" HeaderText="VendorID" 
              SortExpression="VendorID" Visible="False" />
            <asp:BoundField DataField="Name" HeaderText="Name" >
            <ItemStyle Width="225px" />
            </asp:BoundField>
            <asp:BoundField DataField="City" HeaderText="City" >  
             <ItemStyle Width="145px" />
            </asp:BoundField>
            <asp:BoundField DataField="State" HeaderText="State"  >
             <ItemStyle Width="45px" />
            </asp:BoundField>
            <asp:BoundField DataField="ZipCode" HeaderText="ZipCode" >
            <ItemStyle Width="75px" />
            </asp:BoundField>
          </Columns>
          <EditRowStyle BackColor="#2461BF" />
          <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
          <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" HorizontalAlign="Left"/>
          <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
          <RowStyle BackColor="#EFF3FB" />
          <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
          <SortedAscendingCellStyle BackColor="#F5F7FB" />
          <SortedAscendingHeaderStyle BackColor="#6D95E1" />
          <SortedDescendingCellStyle BackColor="#E9EBEF" />
          <SortedDescendingHeaderStyle BackColor="#4870BE" />
          </asp:GridView>
         </div>

    </form>
</body>
</html>
