<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Chapter 14: Terms Maintenance</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h2>Terms Maintenance</h2><br />
        <table>
          <tr>
            <td style="width: 460px" valign="top">
                <asp:GridView ID="grdTerms" runat="server" AutoGenerateColumns="False"
                    DataKeyNames="TermsID" DataSourceID="ObjectDataSource1" 
                    CellPadding="4" ForeColor="#333333" GridLines="None" 
                    onrowdeleted="grdTerms_RowDeleted" onrowupdated="grdTerms_RowUpdated">
                    <Columns>
                        <asp:BoundField DataField="TermsID" HeaderText="TermsID" 
                            Visible="False" />
                        <asp:TemplateField HeaderText="Description">
                            <ItemTemplate>
                                <asp:Label ID="lblGridCategory" runat="server" 
                                    Text='<%# Bind("Description") %>'></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:TextBox ID="txtGridDescription" runat="server" 
                                    Text='<%# Bind("Description") %>'></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" 
                                    runat="server" ControlToValidate="txtGridDescription"
                                    ErrorMessage="Description is a required field." 
                                    ValidationGroup="Edit" ForeColor="White">*
                                </asp:RequiredFieldValidator>
                            </EditItemTemplate>
                            <HeaderStyle HorizontalAlign="Left" />
                            <ItemStyle Width="225px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Due Days">
                            <ItemTemplate>
                                <asp:Label ID="lblGridDueDays" runat="server" 
                                    Text='<%# Bind("DueDays") %>'></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:TextBox ID="txtGridDueDays" runat="server"
                                    Text='<%# Bind("DueDays") %>' Width="40px"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" 
                                    runat="server" ControlToValidate="txtGridDueDays"
                                    ErrorMessage="Due Days is a required field." 
                                    Display="Dynamic" ValidationGroup="Edit" 
                                    ForeColor="White">*
                                </asp:RequiredFieldValidator>
                                <asp:CompareValidator ID="CompareValidator2" runat="server"
                                    ControlToValidate="txtGridDueDays" Display="Dynamic" 
                                    ErrorMessage="Due Days must be an integer." 
                                    Operator="DataTypeCheck" Type="Integer" 
                                    ValidationGroup="Edit" ForeColor="White">*
                                </asp:CompareValidator>
                            </EditItemTemplate>
                            <HeaderStyle HorizontalAlign="Right" />
                            <ItemStyle HorizontalAlign="Right" Width="100px" />
                        </asp:TemplateField>

                        <asp:CommandField ButtonType="Button" ShowEditButton="True" 
                            ValidationGroup="Edit" />
                        <asp:CommandField ButtonType="Button" ShowDeleteButton="True"
                            CausesValidation="False" />
                    </Columns>
                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <AlternatingRowStyle BackColor="White" />
                    <EditRowStyle BackColor="#2461BF" />
                    <RowStyle BackColor="#EFF3FB" />
                </asp:GridView>
                <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetTerms" 
                    UpdateMethod="UpdateTerms" DeleteMethod="DeleteTerms" 
                    OldValuesParameterFormatString="original_{0}"
                    InsertMethod="InsertTerms" TypeName="TermsDB" 
                    ConflictDetection="CompareAllValues" ondeleted="ObjectDataSource1_Deleted" 
                    onupdated="ObjectDataSource1_Updated">
                    <DeleteParameters>
                        <asp:Parameter Name="original_TermsID" Type="Int32" />
                        <asp:Parameter Name="original_Description" Type="String" />
                        <asp:Parameter Name="original_DueDays" Type="Int32" />
                    </DeleteParameters>
                    <UpdateParameters>
                        <asp:Parameter Name="description" Type="String" />
                        <asp:Parameter Name="dueDays" Type="Int32" />
                        <asp:Parameter Name="original_TermsID" Type="Int32" />
                        <asp:Parameter Name="original_Description" Type="String" />
                        <asp:Parameter Name="original_DueDays" Type="Int32" />
                    </UpdateParameters>
                    <InsertParameters>
                        <asp:Parameter Name="description" Type="String" />
                        <asp:Parameter Name="dueDays" Type="Int32" />
                    </InsertParameters>
                </asp:ObjectDataSource>
            </td>
            <td style="width: 100px" valign="top">
                <asp:ValidationSummary ID="ValidationSummary1" runat="server"
                    HeaderText="Please correct the following errors:"
                    ValidationGroup="Edit" Width="240px" />
            </td>
          </tr>
        </table>
        <br />
        <br />
        To add new terms, enter the terms information and click Insert.<br />
        <asp:Label ID="lblError" runat="server" ForeColor="Red" 
            EnableViewState="False"></asp:Label><br />
        <br />
        <table>
          <tr>
            <td style="width: 330px">
                <asp:DetailsView ID="dvTerms" runat="server" AutoGenerateRows="False" 
                    DataSourceID="ObjectDataSource1" DefaultMode="Insert" Height="50px" 
                    Width="320px" CellPadding="4" ForeColor="#333333" GridLines="None" 
                    oniteminserted="dvTerms_ItemInserted">
                    <Fields>
                        <asp:BoundField DataField="TermsID" HeaderText="TermsID" 
                            ReadOnly="True" Visible="False" />
                        <asp:TemplateField HeaderText="Description:">
                            <InsertItemTemplate>
                                <asp:TextBox ID="txtDescription" runat="server" 
                                    Text='<%# Bind("Description") %>'
                                    Width="200px"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" 
                                    runat="server" ControlToValidate="txtDescription"
                                    ErrorMessage="Description is a required field." 
                                    ValidationGroup="Add" Display="Dynamic">*
                                </asp:RequiredFieldValidator>
                            </InsertItemTemplate>
                            <ItemStyle Width="230px" />
                            <HeaderStyle Width="90px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Due Days:">
                            <InsertItemTemplate>
                                <asp:TextBox ID="txtDueDays" runat="server" 
                                    Text='<%# Bind("DueDays") %>' Width="32px"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" 
                                    runat="server" ControlToValidate="txtDueDays"
                                    Display="Dynamic" ErrorMessage="Due Days is a required field." 
                                    ValidationGroup="Add">*</asp:RequiredFieldValidator>
                                <asp:CompareValidator ID="CompareValidator1" runat="server" 
                                    ControlToValidate="txtDueDays" Operator="DataTypeCheck" 
                                    Type="Integer" ErrorMessage="Due Days must be an integer." 
                                    Display="Dynamic" ValidationGroup="Add">*</asp:CompareValidator>
                            </InsertItemTemplate>
                        </asp:TemplateField>
                        <asp:CommandField ButtonType="Button" ShowInsertButton="True" 
                            ValidationGroup="Add" />
                    </Fields>
                    <CommandRowStyle BackColor="#D1DDF1" Font-Bold="True" />
                    <FieldHeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <InsertRowStyle BackColor="#EFF3FB" ForeColor="White" />
                </asp:DetailsView>
            </td>
            <td style="width: 100px">
                <asp:ValidationSummary ID="ValidationSummary2" runat="server" 
                    HeaderText="Please correct the following errors:"
                    ValidationGroup="Add" Width="248px" />
            </td>
          </tr>
        </table>
    </div>
    </form>
</body>
</html>
