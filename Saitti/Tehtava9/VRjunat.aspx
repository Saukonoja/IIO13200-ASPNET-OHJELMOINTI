<%@ Page Language="C#" AutoEventWireup="true" CodeFile="VRjunat.aspx.cs" Inherits="Tehtava9_VRjunat" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:DropDownList ID="ddlCities" AutoPostBack="true" runat="server"></asp:DropDownList>
        <asp:Button ID="btnGetTrains" OnClick="btnGetTrains_Click" Text="Hae lähtevät junat" runat="server" />
        <asp:GridView ID="gvTrains" runat="server"></asp:GridView>
        <asp:Label ID="lblMessages" runat="server"></asp:Label>
    </div>
    </form>
</body>
</html>
