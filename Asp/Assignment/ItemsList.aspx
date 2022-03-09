<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ItemsList.aspx.cs" Inherits="AspAssignment.Items" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <br /><br />
        <div>
            <asp:DropDownList ID="ItemList" runat="server" OnSelectedIndexChanged="ItemList_SelectedIndexChanged" AutoPostBack="True">
                <asp:ListItem Enabled="true">ItemsAvailable</asp:ListItem>
                <asp:ListItem>Flour</asp:ListItem>
                <asp:ListItem>Wheat Flour</asp:ListItem>
                <asp:ListItem>GoodDay</asp:ListItem>
                <asp:ListItem>Oreo</asp:ListItem>
                <asp:ListItem>Yippee Noodles</asp:ListItem>
                <asp:ListItem>Colgate</asp:ListItem>
                <asp:ListItem>Himalaya Soap</asp:ListItem>
            </asp:DropDownList>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </div>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Image ID="Product" runat="server" Height="263px" Width="335px" />
        <br /><br /><br />
        <asp:Button ID="CostBtn" runat="server" Text="Cost" OnClick="CostBtn_Click" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Price" runat="server" Text="Price"></asp:Label>
    </form>
</body>
</html>
