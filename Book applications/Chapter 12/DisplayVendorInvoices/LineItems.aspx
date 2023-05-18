<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LineItems.aspx.cs" Inherits="LineItems" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>Chapter 12: Display Vendor Invoices</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h2>Invoice Line Items</h2><br />
        <table>
            <tr>
                <td style="width: 103px">
                    <asp:Label ID="Label1" runat="server" Text="Vendor:">
                    </asp:Label></td>
                <td style="width: 585px">
                    <asp:TextBox ID="txtVendor" runat="server" ReadOnly="True" 
                        Width="300px"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 103px; height: 5px" />
                <td style="width: 585px; height: 5px" />
             </tr>
            <tr>
                <td style="width: 103px">
                    <asp:Label ID="Label2" runat="server" Text="Invoice Number:">
                    </asp:Label></td>
                <td style="width: 585px">
                    <asp:TextBox ID="txtInvoiceNo" runat="server" ReadOnly="True">
                    </asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 103px; height: 20px">
                </td>
                <td style="width: 585px; height: 20px">
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:GridView ID="grdLineItems" runat="server" AutoGenerateColumns="False" 
                        DataSourceID="SqlDataSource1" CellPadding="4" 
                        ForeColor="#333333" GridLines="None">
                        <Columns>
                            <asp:BoundField DataField="Account" HeaderText="Account">
                                <ItemStyle Width="250px" />
                                <HeaderStyle HorizontalAlign="Left" />
                            </asp:BoundField>
                            <asp:BoundField DataField="Amount" DataFormatString="{0:c}" 
                                HeaderText="Amount" HtmlEncode="False">
                                <ItemStyle HorizontalAlign="Right" Width="75px" />
                                <HeaderStyle HorizontalAlign="Right" />
                            </asp:BoundField>
                            <asp:BoundField DataField="Description" HeaderText="Description">
                                <ItemStyle Width="350px" />
                                <HeaderStyle HorizontalAlign="Left" />
                            </asp:BoundField>
                        </Columns>
                        <EditRowStyle BackColor="#2461BF" />
                        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <AlternatingRowStyle BackColor="White" />
                        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#EFF3FB" />
                        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                        <SortedAscendingCellStyle BackColor="#F5F7FB" />
                        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                        <SortedDescendingCellStyle BackColor="#E9EBEF" />
                        <SortedDescendingHeaderStyle BackColor="#4870BE" />
                    </asp:GridView>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString=
                        "<%$ ConnectionStrings:PayablesConnectionString %>"
                        SelectCommand="SELECT GLAccounts.Description AS Account, 
                            InvoiceLineItems.Amount, InvoiceLineItems.Description 
                            FROM InvoiceLineItems INNER JOIN GLAccounts 
                            ON InvoiceLineItems.AccountNo = GLAccounts.AccountNo 
                            WHERE (InvoiceLineItems.InvoiceID = @InvoiceID)">
                        <SelectParameters>
                            <asp:SessionParameter Name="InvoiceID" SessionField="InvoiceID" />
                        </SelectParameters>
                    </asp:SqlDataSource>
                </td>
            </tr>
            <tr>
                <td style="width: 103px; height: 20px">
                </td>
                <td style="width: 585px; height: 20px">
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="btnReturn" runat="server" Text="Return to Invoices" 
                        onclick="btnReturn_Click" /></td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>

