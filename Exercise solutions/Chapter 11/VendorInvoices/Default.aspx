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
        <asp:DropDownList ID="ddlVendors" runat="server"  Width="250px" 
             AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="Name" 
             DataValueField="VendorID">
        </asp:DropDownList>  
         <br />
         <br />
         <br />
         <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
             ConnectionString="<%$ ConnectionStrings:PayablesConnectionString %>" 
             SelectCommand="SELECT [VendorID], [Name] FROM [Vendors] ORDER BY [Name]">
         </asp:SqlDataSource>
         <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
             ConnectionString="<%$ ConnectionStrings:PayablesConnectionString %>" 
             SelectCommand="SELECT [InvoiceID], [InvoiceNumber], [InvoiceDate], [InvoiceTotal] FROM [Invoices] WHERE ([VendorID] = @VendorID) ORDER BY [InvoiceDate]">
             <SelectParameters>
                 <asp:ControlParameter ControlID="ddlVendors" Name="VendorID" 
                     PropertyName="SelectedValue" Type="Int32" />
             </SelectParameters>
         </asp:SqlDataSource>
         <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
             CellPadding="4" DataKeyNames="InvoiceID" DataSourceID="SqlDataSource2" 
             ForeColor="#333333" GridLines="None">
             <AlternatingRowStyle BackColor="White" />
             <Columns>
                 <asp:BoundField DataField="InvoiceID" HeaderText="InvoiceID" 
                     InsertVisible="False" ReadOnly="True" SortExpression="InvoiceID" 
                     Visible="False" />
                 <asp:BoundField DataField="InvoiceNumber" HeaderText="Invoice Number" 
                     SortExpression="InvoiceNumber" />
                 <asp:BoundField DataField="InvoiceDate" DataFormatString="{0:d}" 
                     HeaderText="Invoice Date" SortExpression="InvoiceDate" />
                 <asp:BoundField DataField="InvoiceTotal" DataFormatString="{0:c}" 
                     HeaderText="Invoice Total" SortExpression="InvoiceTotal" />
             </Columns>
             <EditRowStyle BackColor="#2461BF" />
             <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
             <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
             <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
             <RowStyle BackColor="#EFF3FB" />
             <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
             <SortedAscendingCellStyle BackColor="#F5F7FB" />
             <SortedAscendingHeaderStyle BackColor="#6D95E1" />
             <SortedDescendingCellStyle BackColor="#E9EBEF" />
             <SortedDescendingHeaderStyle BackColor="#4870BE" />
         </asp:GridView>
         <br />
      
    </div>
    </form>
</body>
</html>
