<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
   <title>Chapter 13: Vendor Maintenance with DetailsView</title>
</head>
<body>
  <form id="form1" runat="server">
  <div>
    <h2>Vendor Maintenance</h2>
    <table>
      <tr>
        <td style="width: 520px" valign="top">
          <asp:GridView ID="grdVendors" runat="server" AllowPaging="True" 
              AutoGenerateColumns="False" DataKeyNames="VendorID" 
              DataSourceID="SqlDataSource1" CellPadding="4" ForeColor="#333333"
              GridLines="None" PageSize="15" SelectedIndex="0">
            <Columns>
              <asp:BoundField DataField="VendorID" HeaderText="VendorID" 
                  Visible="False" />
              <asp:BoundField DataField="Name" HeaderText="Name">
                <ItemStyle Width="225px" />
                <HeaderStyle HorizontalAlign="Left" />
              </asp:BoundField>
              <asp:BoundField DataField="City" HeaderText="City">
                <ItemStyle Width="130px" />
                <HeaderStyle HorizontalAlign="Left" />
              </asp:BoundField>
              <asp:BoundField DataField="State" HeaderText="State">
                <ItemStyle Width="65px" />
                <HeaderStyle HorizontalAlign="Left" />
              </asp:BoundField>
              <asp:CommandField ButtonType="Button" ShowSelectButton="True" />
            </Columns>
            <SelectedRowStyle BackColor="LightSteelBlue" Font-Bold="True" 
                ForeColor="#333333" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" 
                HorizontalAlign="Center" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <AlternatingRowStyle BackColor="White" />
            <RowStyle BackColor="#EFF3FB" />
            <PagerSettings Mode="NextPreviousFirstLast" />
          </asp:GridView>
          <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
              ConnectionString="<%$ ConnectionStrings:PayablesConnectionString %>"
              SelectCommand="SELECT [VendorID], [Name], [City], [State] 
                  FROM [Vendors] ORDER BY [Name]">
          </asp:SqlDataSource>
        </td>
        <td style="width: 430px" valign="top">
          <asp:DetailsView ID="dvVendor" runat="server" AutoGenerateRows="False" 
              DataKeyNames="VendorID" DataSourceID="SqlDataSource2" Height="50px" 
              Width="425" BackColor="White" BorderColor="White" BorderStyle="Ridge" 
              BorderWidth="2px" CellPadding="3" CellSpacing="1" GridLines="None" 
                onitemdeleted="dvVendor_ItemDeleted" oniteminserted="dvVendor_ItemInserted" 
                onitemupdated="dvVendor_ItemUpdated">
            <Fields>
              <asp:BoundField DataField="VendorID" HeaderText="VendorID" 
                  Visible="False" />
              <asp:TemplateField HeaderText="Name:">
                <ItemTemplate>
                  <asp:Label ID="Label4" runat="server" 
                      Text='<%# Bind("Name") %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                  <asp:TextBox ID="txtName" runat="server" 
                      Text='<%# Bind("Name") %>' Width="300px"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator1" 
                      runat="server" ControlToValidate="txtName"
                      ErrorMessage="Name is a required field.">*
                  </asp:RequiredFieldValidator>
                </EditItemTemplate>
                <InsertItemTemplate>
                  <asp:TextBox ID="txtName" runat="server" 
                      Text='<%# Bind("Name") %>' Width="300px"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator5" 
                      runat="server" ControlToValidate="txtName"
                      ErrorMessage="Name is a required field.">*
                  </asp:RequiredFieldValidator>
                </InsertItemTemplate>
                <ItemStyle Width="335px" />
                <HeaderStyle Width="90px" />
              </asp:TemplateField>
              <asp:TemplateField HeaderText="Address 1:">
                <ItemTemplate>
                  <asp:Label ID="Label5" runat="server" 
                      Text='<%# Bind("Address1") %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                  <asp:TextBox ID="txtAddress1" runat="server" 
                      Text='<%# Bind("Address1") %>' Width="300px"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator2" 
                      runat="server" ControlToValidate="txtAddress1"
                      ErrorMessage="Address 1 is a required field.">*
                  </asp:RequiredFieldValidator>
                </EditItemTemplate>
                <InsertItemTemplate>
                  <asp:TextBox ID="txtAddress1" runat="server" 
                      Text='<%# Bind("Address1") %>' Width="300px"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator6" 
                      runat="server" ControlToValidate="txtAddress1"
                      ErrorMessage="Address 1 is a required field.">*
                  </asp:RequiredFieldValidator>
                </InsertItemTemplate>
              </asp:TemplateField>
              <asp:TemplateField HeaderText="Address 2:">
                <ItemTemplate>
                  <asp:Label ID="Label6" runat="server" 
                      Text='<%# Bind("Address2") %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                  <asp:TextBox ID="txtAddress2" runat="server" 
                      Text='<%# Bind("Address2") %>' Width="300px"></asp:TextBox>
                </EditItemTemplate>
                <InsertItemTemplate>
                  <asp:TextBox ID="txtAddress2" runat="server" 
                      Text='<%# Bind("Address2") %>' Width="300px"></asp:TextBox>
                </InsertItemTemplate>
              </asp:TemplateField>
              <asp:TemplateField HeaderText="City:">
                <ItemTemplate>
                  <asp:Label ID="Label7" runat="server" 
                      Text='<%# Bind("City") %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                  <asp:TextBox ID="txtCity" runat="server" 
                      Text='<%# Bind("City") %>' Width="300px"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator3" 
                      runat="server" ControlToValidate="txtCity"
                      ErrorMessage="City is a required field.">*
                  </asp:RequiredFieldValidator>
                  </EditItemTemplate>
                <InsertItemTemplate>
                  <asp:TextBox ID="txtCity" runat="server" 
                      Text='<%# Bind("City") %>' Width="300px"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator7" 
                      runat="server" ControlToValidate="txtCity"
                      ErrorMessage="City is a required field.">*
                  </asp:RequiredFieldValidator>
                </InsertItemTemplate>
              </asp:TemplateField>
              <asp:TemplateField HeaderText="State:">
                <ItemTemplate>
                  <asp:Label ID="Label1" runat="server" 
                      Text='<%# Bind("State") %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                  <asp:DropDownList ID="ddlState" runat="server" 
                      DataSourceID="SqlDataSource3" DataTextField="StateName"
                      DataValueField="StateCode" SelectedValue='<%# Bind("State") %>' 
                      Width="160px">
                  </asp:DropDownList>
                </EditItemTemplate>
                <InsertItemTemplate>
                  <asp:DropDownList ID="ddlState" runat="server"
                      DataSourceID="SqlDataSource3" DataTextField="StateName" 
                      DataValueField="StateCode" SelectedValue='<%# Bind("State") %>' 
                      Width="160px">
                  </asp:DropDownList>
                </InsertItemTemplate>
              </asp:TemplateField>
              <asp:TemplateField HeaderText="Zip Code:">
                <ItemTemplate>
                  <asp:Label ID="Label8" runat="server" 
                      Text='<%# Bind("ZipCode") %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                  <asp:TextBox ID="txtZipCode" runat="server" 
                      Text='<%# Bind("ZipCode") %>' Width="120px"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator4" 
                      runat="server" ControlToValidate="txtZipCode"
                      ErrorMessage="Zip Code is a required field.">*
                  </asp:RequiredFieldValidator>
                </EditItemTemplate>
                <InsertItemTemplate>
                  <asp:TextBox ID="txtZipCode" runat="server" 
                      Text='<%# Bind("ZipCode") %>' Width="120px"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator8" 
                      runat="server" ControlToValidate="txtZipCode"
                      ErrorMessage="Zip Code is a required field.">*
                  </asp:RequiredFieldValidator>
                </InsertItemTemplate>
              </asp:TemplateField>

              <asp:CommandField ButtonType="Button" ShowDeleteButton="True" 
                  ShowEditButton="True" ShowInsertButton="True" />
            </Fields>
            <RowStyle BackColor="#EFF3FB" ForeColor="Black" />
            <EditRowStyle BackColor="LightSteelBlue" Font-Bold="True" 
                ForeColor="White" />
            <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" />
          </asp:DetailsView>

          <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
              ConflictDetection="CompareAllValues"
              ConnectionString="<%$ ConnectionStrings:PayablesConnectionString %>" 
              OldValuesParameterFormatString="original_{0}" 
              SelectCommand="SELECT [VendorID], [Name], [Address1], [Address2],
                      [City], [State], [ZipCode]
                  FROM Vendors 
                  WHERE VendorID = @VendorID"
              DeleteCommand="DELETE FROM [Vendors] 
                  WHERE [VendorID] = @original_VendorID 
                    AND [Name] = @original_Name 
                    AND [Address1] = @original_Address1 
                    AND  ([Address2] = @original_Address2
                       OR Address2 IS NULL AND @original_Address2 IS NULL )
                    AND [City] = @original_City 
                    AND [State] = @original_State 
                    AND [ZipCode] = @original_ZipCode"
              InsertCommand="INSERT INTO [Vendors]
                      ([Name], [Address1], [Address2], [City], [State], [ZipCode]) 
                  VALUES (@Name, @Address1, @Address2, @City, @State, @ZipCode)"
              UpdateCommand="UPDATE [Vendors] 
                  SET [Name] = @Name, [Address1] = @Address1, 
                      [Address2] = @Address2, [City] = @City, 
                      [State] = @State, [ZipCode] = @ZipCode 
                  WHERE [VendorID] = @original_VendorID 
                    AND [Name] = @original_Name 
                    AND [Address1] = @original_Address1 
                    AND ( [Address2] = @original_Address2
                       OR Address2 IS NULL AND @original_Address2 IS NULL ) 
                    AND [City] = @original_City 
                    AND [State] = @original_State 
                    AND [ZipCode] = @original_ZipCode">
            <SelectParameters>
              <asp:ControlParameter ControlID="grdVendors" Name="VendorID" 
                  PropertyName="SelectedValue" Type="Int32" />
            </SelectParameters>
            <DeleteParameters>
              <asp:Parameter Name="original_VendorID" Type="Int32" />
              <asp:Parameter Name="original_Name" Type="String" />
              <asp:Parameter Name="original_Address1" Type="String" />
              <asp:Parameter Name="original_Address2" Type="String" />
              <asp:Parameter Name="original_City" Type="String" />
              <asp:Parameter Name="original_State" Type="String" />
              <asp:Parameter Name="original_ZipCode" Type="String" />
            </DeleteParameters>
            <UpdateParameters>
              <asp:Parameter Name="Name" Type="String" />
              <asp:Parameter Name="Address1" Type="String" />
              <asp:Parameter Name="Address2" Type="String" />
              <asp:Parameter Name="City" Type="String" />
              <asp:Parameter Name="State" Type="String" />
              <asp:Parameter Name="ZipCode" Type="String" />
              <asp:Parameter Name="original_VendorID" Type="Int32" />
              <asp:Parameter Name="original_Name" Type="String" />
              <asp:Parameter Name="original_Address1" Type="String" />
              <asp:Parameter Name="original_Address2" Type="String" />
              <asp:Parameter Name="original_City" Type="String" />
              <asp:Parameter Name="original_State" Type="String" />
              <asp:Parameter Name="original_ZipCode" Type="String" />
            </UpdateParameters>
            <InsertParameters>
              <asp:Parameter Name="Name" Type="String" />
              <asp:Parameter Name="Address1" Type="String" />
              <asp:Parameter Name="Address2" Type="String" />
              <asp:Parameter Name="City" Type="String" />
              <asp:Parameter Name="State" Type="String" />
              <asp:Parameter Name="ZipCode" Type="String" />
            </InsertParameters>
          </asp:SqlDataSource>
          <asp:SqlDataSource ID="SqlDataSource3" runat="server" 
              ConnectionString="<%$ ConnectionStrings:PayablesConnectionString %>"
              SelectCommand="SELECT [StateCode], [StateName] FROM [States] 
                  ORDER BY [StateName]">
          </asp:SqlDataSource>
          <br />
          <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
              HeaderText="Please correct the following errors:" />
          <br />
          <asp:Label ID="lblError" runat="server" EnableViewState="False" 
              ForeColor="Red"></asp:Label>
        </td>
      </tr>
    </table>
  </div>
  </form>
</body>
</html>