<%@ Page Language="C#" AutoEventWireup="true" CodeFile="VendorInvoices.aspx.cs" Inherits="VendorInvoices" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>Chapter 12: Display Vendor Invoices</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h2>Vendor Invoices</h2>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        Choose a vendor:&nbsp;&nbsp;<asp:DropDownList ID="ddlVendors" 
            runat="server" DataSourceID="SqlDataSource1" DataTextField="Name" 
            DataValueField="VendorID" Width="248px" AutoPostBack="True">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:PayablesConnectionString %>"
            SelectCommand="SELECT [VendorID], [Name] FROM [Vendors] ORDER BY [Name]">
        </asp:SqlDataSource> <br /> <br />


        <asp:GridView ID="grdInvoices" runat="server" AutoGenerateColumns="False"
            DataKeyNames="InvoiceID" DataSourceID="SqlDataSource2" CellPadding="4" 
            ForeColor="#333333" GridLines="None"
            AllowPaging="True" AllowSorting="True" 
            onrowcommand="grdInvoices_RowCommand">
            <Columns>
                <asp:BoundField DataField="InvoiceID" HeaderText="InvoiceID" 
                    Visible="False" >
                </asp:BoundField>
                <asp:BoundField DataField="InvoiceNumber" HeaderText="Invoice No"
                    SortExpression="InvoiceNumber" >
                    <ItemStyle Width="100px" />
                    <HeaderStyle HorizontalAlign="Left" />
                </asp:BoundField>
                <asp:BoundField DataField="InvoiceDate" DataFormatString="{0:d}"
                    HeaderText="Invoice Date" SortExpression="InvoiceDate" 
                    HtmlEncode="False" >
                    <ItemStyle Width="95px" HorizontalAlign="Right" />
                    <HeaderStyle HorizontalAlign="Right" />
                </asp:BoundField>
                <asp:BoundField DataField="InvoiceTotal" DataFormatString="{0:c}"
                    HeaderText="Invoice Total" SortExpression="InvoiceTotal" 
                    HtmlEncode="False" >
                    <ItemStyle HorizontalAlign="Right" Width="100px" />
                    <HeaderStyle HorizontalAlign="Right" />
                </asp:BoundField>
                <asp:BoundField DataField="PaymentTotal" DataFormatString="{0:c}"
                    HeaderText="Payment Total" HtmlEncode="False" >
                    <ItemStyle HorizontalAlign="Right" Width="110px" />
                    <HeaderStyle HorizontalAlign="Right" />
                </asp:BoundField>
                <asp:BoundField DataField="CreditTotal" DataFormatString="{0:c}"
                    HeaderText="Credit Total" HtmlEncode="False" >
                    <ItemStyle HorizontalAlign="Right" Width="90px" />
                    <HeaderStyle HorizontalAlign="Right" />
                </asp:BoundField>
                <asp:BoundField DataField="BalanceDue" DataFormatString="{0:c}"
                    HeaderText="Balance Due" HtmlEncode="False" 
                    SortExpression="BalanceDue">
                    <ItemStyle HorizontalAlign="Right" Width="90px" />
                    <HeaderStyle HorizontalAlign="Right" />
                </asp:BoundField>
                <asp:BoundField DataField="DueDate" DataFormatString="{0:d}" 
                    HeaderText="Due Date" HtmlEncode="False" SortExpression="DueDate">
                    <ItemStyle Width="75px" HorizontalAlign="Right" />
                    <HeaderStyle HorizontalAlign="Right" />
                </asp:BoundField>
                <asp:ButtonField ButtonType="Button" CommandName="ViewLineItems"
                    Text="View Line Items" />
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <AlternatingRowStyle BackColor="White" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server"
            ConnectionString="<%$ ConnectionStrings:PayablesConnectionString %>"
            SelectCommand="SELECT InvoiceID, InvoiceNumber, InvoiceDate, InvoiceTotal, 
                PaymentTotal, CreditTotal, InvoiceTotal - PaymentTotal - CreditTotal 
                AS BalanceDue, DueDate FROM Invoices 
                WHERE (VendorID = @VendorID) ORDER BY InvoiceDate">
            <SelectParameters>
                <asp:ControlParameter ControlID="ddlVendors" Name="VendorID"
                    PropertyName="SelectedValue" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
        </div>
    </form>
</body>
</html>

