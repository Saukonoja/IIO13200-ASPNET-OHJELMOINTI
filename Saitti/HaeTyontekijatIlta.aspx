<%@ Page Language="C#" AutoEventWireup="true" CodeFile="HaeTyontekijatIlta.aspx.cs" Inherits="HaeTyontekijatIlta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tyontekijat</title>
    <link rel="stylesheet" href="http://www.w3schools.com/lib/w3.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div id="buttoset">
        <asp:Button ID="btnGet" runat="server" Class="w3-btn w3-green" Text="Hae Työntekijät" OnClick="btnGet_Click" />
    </div>
    <div id="esitys" class="w3-blue">
        <asp:GridView ID="gvData" runat="server"></asp:GridView>
    </div>
    <div id="footer" class="w3-container w3-teal">
        <asp:Label ID="lblMessage"  runat="server" Text="..."></asp:Label>
    </div>
    </form>
</body>
</html>
