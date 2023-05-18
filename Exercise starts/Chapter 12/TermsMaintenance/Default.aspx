<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Exercise 12-1: Terms Maintenance </title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
            <h2>Terms Maintenance</h2>
       
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConflictDetection="CompareAllValues"
            ConnectionString="<%$ ConnectionStrings:PayablesConnectionString %>" 
            OldValuesParameterFormatString="original_{0}" 
            SelectCommand="SELECT [TermsID], [Description], [DueDays]
                 FROM [Terms]"
            DeleteCommand="DELETE FROM [Terms] 
                WHERE [TermsID] = @original_TermsID 
                  AND [Description] = @original_Description 
                  AND [DueDays] = @original_DueDays"
            InsertCommand="INSERT INTO [Terms] 
                ([Description], [DueDays]) 
                VALUES (@Description, @DueDays)"
            UpdateCommand="UPDATE [Terms] 
                SET [Description] = @Description, 
                    [DueDays] = @DueDays 
                WHERE [TermsID] = @original_TermsID 
                  AND [Description] = @original_Description 
                  AND [DueDays] = @original_DueDays">
            <DeleteParameters>
                <asp:Parameter Name="original_TermsID" Type="Int32" />
                <asp:Parameter Name="original_Description" Type="String" />
                <asp:Parameter Name="original_DueDays" Type="Int16" />
            </DeleteParameters>
            <UpdateParameters>
                <asp:Parameter Name="Description" Type="String" />
                <asp:Parameter Name="DueDays" Type="Int16" />
                <asp:Parameter Name="original_TermsID" Type="Int32" />
                <asp:Parameter Name="original_Description" Type="String" />
                <asp:Parameter Name="original_DueDays" Type="Int16" />
            </UpdateParameters>
            <InsertParameters>
                <asp:Parameter Name="Description" Type="String" />
                <asp:Parameter Name="DueDays" Type="Int16" />
            </InsertParameters>
        </asp:SqlDataSource>

            <br />

        To add new terms, enter the terms information and click Add Terms.
        <br />
        <asp:Label ID="lblError" runat="server" ForeColor="Red" 
            EnableViewState="False"></asp:Label><br /><br />
        <table>
          <tr>
            <td style="width: 80px">Description:</td>
            <td style="width: 124px">
                <asp:TextBox ID="txtDescription" runat="server" Width="200px">
                </asp:TextBox></td>
            <td style="width: 184px">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" 
                    runat="server" ControlToValidate="txtDescription"
                    ErrorMessage="Description is a required field." 
                    Width="184px"></asp:RequiredFieldValidator></td>
          </tr>
          <tr>
            <td style="width: 80px">Due Days:</td>
            <td style="width: 124px">
                <asp:TextBox ID="txtDueDays" runat="server" Width="32px">
                </asp:TextBox></td>
            <td style="width: 184px">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" 
                    runat="server" ControlToValidate="txtDueDays"
                    ErrorMessage="Due Days is a required field." 
                    Display="Dynamic" Width="176px">
                </asp:RequiredFieldValidator>
                <asp:CompareValidator ID="CompareValidator1" runat="server"
                    ErrorMessage="Due Days must be an integer." 
                    Operator="DataTypeCheck" ControlToValidate="txtDueDays" 
                    Type="Integer" Display="Dynamic" Width="184px">
                </asp:CompareValidator></td>
          </tr>
        </table>
        <br />
        <asp:Button ID="btnAdd" runat="server" Text="Add Terms" />
    </div>
    </form>
</body>
</html>
