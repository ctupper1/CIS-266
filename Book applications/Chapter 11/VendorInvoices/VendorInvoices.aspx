<%@ Page Language="C#" AutoEventWireup="true" CodeFile="VendorInvoices.aspx.cs" Inherits="VendorInvoices" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>Chapter 11: Display Vendor Invoices</title>
</head>
<body>
  <form id="form1" runat="server">
    <div>
        <h2>Vendor Invoices</h2><br />
        Choose a vendor:&nbsp;&nbsp;
        <asp:DropDownList ID="ddlVendors" runat="server"  Width="248px"
            AutoPostBack="True" DataSourceID="SqlDataSource1"
            DataTextField="Name" DataValueField="VendorID">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:PayablesConnectionString %>"
            SelectCommand="SELECT [VendorID], [Name] FROM [Vendors] 
                           ORDER BY [Name]">
        </asp:SqlDataSource><br /><br />
        <asp:GridView ID="grdInvoices" runat="server" 
            AutoGenerateColumns="False"
            DataSourceID="SqlDataSource2" BackColor="White" 
            BorderColor="#999999" BorderStyle="Solid"
            BorderWidth="1px" CellPadding="3" ForeColor="Black" 
            GridLines="Vertical">
            <Columns>
              <asp:BoundField DataField="InvoiceID" HeaderText="InvoiceID"
                  SortExpression="InvoiceID" Visible="False" >
              </asp:BoundField>
              <asp:BoundField DataField="InvoiceNumber" 
                  HeaderText="Invoice No" SortExpression="InvoiceNumber" >
                  <ItemStyle Width="100px" />
                  <HeaderStyle HorizontalAlign="Left" />
              </asp:BoundField>
              <asp:BoundField DataField="InvoiceDate" 
                  DataFormatString="{0:d}"  
                  HeaderText="Invoice Date" SortExpression="InvoiceDate" >
                  <ItemStyle Width="95px" HorizontalAlign="Right" />
                  <HeaderStyle HorizontalAlign="Right" />
              </asp:BoundField>
              <asp:BoundField DataField="InvoiceTotal" 
                  DataFormatString="{0:c}" 
                  HeaderText="Invoice Total" SortExpression="InvoiceTotal" >
                  <ItemStyle Width="100px" HorizontalAlign="Right" />
                  <HeaderStyle HorizontalAlign="Right" />
              </asp:BoundField>
              <asp:BoundField DataField="PaymentTotal" 
                  DataFormatString="{0:c}" HeaderText="Payment Total" >
                  <ItemStyle Width="110px" HorizontalAlign="Right" />
                  <HeaderStyle HorizontalAlign="Right" />
              </asp:BoundField>
              <asp:BoundField DataField="CreditTotal" 
                  DataFormatString="{0:c}" 
                  HeaderText="Credit Total" >
                  <ItemStyle HorizontalAlign="Right" Width="90px" />
                  <HeaderStyle HorizontalAlign="Right" />
              </asp:BoundField>
              <asp:BoundField DataField="BalanceDue" 
                  DataFormatString="{0:c}" 
                  HeaderText="Balance Due" SortExpression="BalanceDue">
                  <ItemStyle Width="90px" HorizontalAlign="Right" />
                  <HeaderStyle HorizontalAlign="Right" />
              </asp:BoundField>
              <asp:BoundField DataField="DueDate" 
                  DataFormatString="{0:d}" HeaderText="Due Date"
                  SortExpression="DueDate">
                  <ItemStyle Width="75px" HorizontalAlign="Right" />
                  <HeaderStyle HorizontalAlign="Right" />
              </asp:BoundField>
            </Columns>
            <FooterStyle BackColor="#CCCCCC" />
            <SelectedRowStyle BackColor="#000099" Font-Bold="True" 
                ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" 
                HorizontalAlign="Center" />
            <HeaderStyle BackColor="Black" Font-Bold="True" 
                ForeColor="White" />
            <AlternatingRowStyle BackColor="#CCCCCC" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server"
          ConnectionString="<%$ ConnectionStrings:PayablesConnectionString %>"
          SelectCommand="SELECT InvoiceID, InvoiceNumber, InvoiceDate, 
              InvoiceTotal, PaymentTotal, CreditTotal, 
              InvoiceTotal - PaymentTotal - CreditTotal AS BalanceDue, 
              DueDate 
              FROM Invoices 
              WHERE (VendorID = @VendorID) 
              ORDER BY InvoiceDate">
          <SelectParameters>
             <asp:ControlParameter ControlID="ddlVendors" Name="VendorID"
                 PropertyName="SelectedValue" Type="Int32" />
          </SelectParameters>
        </asp:SqlDataSource>
    </div>
  </form>
</body>
</html>

