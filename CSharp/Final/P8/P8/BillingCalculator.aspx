<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BillingCalculator.aspx.cs" Inherits="P8.BillingCalculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            <asp:Label ID="Label2" runat="server" Text="QTY: "></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" style="margin-left: 10px" Width="127px"></asp:TextBox>
        </p>
        <asp:Label ID="Label4" runat="server" Text="PRICE:"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server" style="margin-left: 10px" Width="118px"></asp:TextBox>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="margin-left: 89px" Text="Add" />
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Total: "></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 10px" Width="127px"></asp:TextBox>
            <asp:Label ID="Label5" runat="server" Text="0" Visible="False"></asp:Label>
        </p>
    </form>
</body>
</html>
