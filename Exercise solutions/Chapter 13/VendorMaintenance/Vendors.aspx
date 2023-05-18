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
  
    <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" 
        CellPadding="4" DataKeyNames="VendorID" DataSourceID="SqlDataSource2" 
        ForeColor="#333333" GridLines="None" Height="50px" Width="349px" 
        oniteminserted="DetailsView1_ItemInserted">
        <AlternatingRowStyle BackColor="White" />
        <CommandRowStyle BackColor="#C5BBAF" Font-Bold="True" />
        <EditRowStyle BackColor="#7C6F57" />
        <FieldHeaderStyle BackColor="#D0D0D0" Font-Bold="True" />
        <Fields>
            <asp:BoundField DataField="VendorID" HeaderText="VendorID" 
                InsertVisible="False" ReadOnly="True" SortExpression="VendorID" />
            <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
            <asp:BoundField DataField="Address1" HeaderText="Address1" 
                SortExpression="Address1" />
            <asp:BoundField DataField="Address2" HeaderText="Address2" 
                SortExpression="Address2" />
            <asp:BoundField DataField="City" HeaderText="City" SortExpression="City" />
            <asp:BoundField DataField="State" HeaderText="State" SortExpression="State" />
            <asp:BoundField DataField="ZipCode" HeaderText="ZipCode" 
                SortExpression="ZipCode" />
            <asp:BoundField DataField="Phone" HeaderText="Phone" SortExpression="Phone" />
            <asp:CommandField ButtonType="Button" ShowInsertButton="True" />
        </Fields>
        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#E3EAEB" />
    </asp:DetailsView>
    <br />
    <br />
      <asp:Label ID="lblMessage" runat="server" Text=" "></asp:Label>
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
        ConnectionString="<%$ ConnectionStrings:PayablesConnectionString %>" 
        InsertCommand="INSERT INTO Vendors(Name, Address1, Address2, City, State, ZipCode, Phone) VALUES (@Name, @Address1, @Address2, @City, @State, @ZipCode, @Phone)" 
        SelectCommand="SELECT [VendorID], [Name], [Address1], [Address2], [City], [State], [ZipCode], [Phone] FROM [Vendors] WHERE ([VendorID] = @VendorID)">
        <InsertParameters>
            <asp:Parameter Name="Name" />
            <asp:Parameter Name="Address1" />
            <asp:Parameter Name="Address2" />
            <asp:Parameter Name="City" />
            <asp:Parameter Name="State" />
            <asp:Parameter Name="ZipCode" />
            <asp:Parameter Name="Phone" />
        </InsertParameters>
        <SelectParameters>
            <asp:ControlParameter ControlID="ddlVendors" Name="VendorID" 
                PropertyName="SelectedValue" Type="Int32" />
        </SelectParameters>
    </asp:SqlDataSource>
    </form>
</body>
</html>

