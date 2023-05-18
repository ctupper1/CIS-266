<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
      <title>Chapter 14: Display Vendor Invoices</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h2>Vendor Invoices</h2><br />
        Vendor:
        <asp:DropDownList ID="ddlVendors" runat="server" 
               AutoPostBack="True">
        </asp:DropDownList>

        <br />
        <br />
        <asp:GridView ID="grdInvoices" runat="server" 
            AutoGenerateColumns="False" DataSourceID="ObjectDataSource2"
            BackColor="White" BorderColor="#999999" BorderStyle="Solid"
            BorderWidth="1px" CellPadding="3" ForeColor="Black" 
            GridLines="Vertical">
            <Columns>
                <asp:BoundField DataField="InvoiceNumber" 
                    HeaderText="Invoice No" SortExpression="InvoiceNumber" >
                    <ItemStyle Width="100px" />
                    <HeaderStyle HorizontalAlign="Left" />
                </asp:BoundField>
                <asp:BoundField DataField="InvoiceDate" DataFormatString="{0:d}"
                    HeaderText="Invoice Date" SortExpression="InvoiceDate" 
                    HtmlEncode="False" >
                    <ItemStyle Width="95px" HorizontalAlign="Right" />
                    <HeaderStyle HorizontalAlign="Right" />
                </asp:BoundField>
                <asp:BoundField DataField="InvoiceTotal" 
                    DataFormatString="{0:c}" HeaderText="Invoice Total" 
                    SortExpression="InvoiceTotal" HtmlEncode="False" >
                    <ItemStyle HorizontalAlign="Right" Width="100px" />
                    <HeaderStyle HorizontalAlign="Right" />
                </asp:BoundField>
                <asp:BoundField DataField="PaymentTotal" 
                    DataFormatString="{0:c}" HeaderText="Payment Total" 
                    HtmlEncode="False" >
                    <ItemStyle HorizontalAlign="Right" Width="110px" />
                    <HeaderStyle HorizontalAlign="Right" />
                </asp:BoundField>
                <asp:BoundField DataField="CreditTotal" 
                    DataFormatString="{0:c}" HeaderText="Credit Total" 
                    HtmlEncode="False" >
                    <ItemStyle HorizontalAlign="Right" Width="90px" />
                    <HeaderStyle HorizontalAlign="Right" />
                </asp:BoundField>
                <asp:BoundField DataField="BalanceDue" 
                    DataFormatString="{0:c}" HeaderText="Balance Due" 
                    HtmlEncode="False" SortExpression="BalanceDue">
                    <ItemStyle HorizontalAlign="Right" Width="90px" />
                    <HeaderStyle HorizontalAlign="Right" />
                </asp:BoundField>
                <asp:BoundField DataField="DueDate" DataFormatString="{0:d}" 
                    HeaderText="Due Date" HtmlEncode="False" 
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
        <asp:ObjectDataSource ID="ObjectDataSource2" runat="server"
            SelectMethod="GetInvoicesByVendor" TypeName="InvoiceDB">
            <SelectParameters>
                <asp:ControlParameter ControlID="ddlVendors" Name="vendorID" 
                    PropertyName="SelectedValue" Type="Int32" />
            </SelectParameters>
        </asp:ObjectDataSource>
        </div>
    </form>
</body>
</html>
