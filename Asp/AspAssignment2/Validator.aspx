<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Validator.aspx.cs" Inherits="AspAssignment2.Validator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h5>Insert Your Details:</h5>
            <br />
            <table class="auto-style1">
                <tr>
                    <td>Name:</td>
                    <td><asp:TextBox ID="name" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Enter Name" ControlToValidate="name" ForeColor="Red">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>Family Name:</td>
                    <td><asp:TextBox ID="familyname" runat="server"></asp:TextBox>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Should not be same as Name" ControlToCompare="name" ControlToValidate="familyname" ForeColor="Red" Operator="NotEqual">*</asp:CompareValidator>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Enter FamilyName" ForeColor="Red" ControlToValidate="familyname">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>Address:</td>
                    <td><asp:TextBox ID="addr" runat="server"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="At least 2 characters" ControlToValidate="addr" ForeColor="Red" ValidationExpression="[a-zA-Z]{2,}">*</asp:RegularExpressionValidator>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Enter Address" ForeColor="Red" ControlToValidate="addr">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>City:</td>
                    <td><asp:TextBox ID="city" runat="server"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="At least 2 characters" ControlToValidate="city" ForeColor="Red" ValidationExpression="[a-zA-Z]{2,}">*</asp:RegularExpressionValidator>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Enter City" ForeColor="Red" ControlToValidate="city">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>Zip Code:</td>
                    <td><asp:TextBox ID="zip" runat="server"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ErrorMessage="Must be 5 digits" ControlToValidate="zip" ForeColor="Red" ValidationExpression="\d{5}">*</asp:RegularExpressionValidator>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Enter zip code" ForeColor="Red" ControlToValidate="zip">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>Phone:</td>
                    <td><asp:TextBox ID="phone" runat="server"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ErrorMessage="Must be 10 digits" ControlToValidate="phone" ForeColor="Red" ValidationExpression="\d{10}">*</asp:RegularExpressionValidator>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Enter Contact Number" ForeColor="Red" ControlToValidate="phone">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>Email:</td>
                    <td><asp:TextBox ID="email" runat="server"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ErrorMessage="Enter Valid Email" ControlToValidate="email" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="Enter Email" ForeColor="Red" ControlToValidate="email">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
            </table>
        </div>
        <br />
        <asp:Button ID="checkbtn" runat="server" Text="Check" OnClick="checkbtn_Click" />
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowMessageBox="true" ShowSummary="true" ForeColor="Red"/>
    </form>
</body>
</html>
