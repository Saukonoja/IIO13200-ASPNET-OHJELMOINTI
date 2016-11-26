<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Lotto.aspx.cs" Inherits="Tehtava2_Lotto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Lotto</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Lotto</h1>
        <asp:DropDownList ID="ddlLotto" runat="server">
            <asp:ListItem Selected="True" Value="Lotto" Text="Lotto"></asp:ListItem>
            <asp:ListItem Value="Viking" Text="Viking Lotto"></asp:ListItem>
        </asp:DropDownList>
        <h2>Rivien lukumäärä</h2>
        <asp:TextBox ID="txtRows" Text="1" Width="40px" runat="server"></asp:TextBox>
        <asp:Button ID="btnProfit" Text="Arvo numerot" runat="server" OnClick="btnProfit_Click" />
        <h2>Tulokset:</h2>
        <asp:Label ID="lblResult" runat="server"></asp:Label>
    </div>
    </form>
</body>
</html>
