<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ShowFeedback.aspx.cs" Inherits="Tehtava7_ShowFeedback" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Palautteet</h1>
        <asp:Button ID="btnGetFromXml" runat="server" Text="Hae palautteet Xml" OnClick="btnGetFromXml_Click" />
        <asp:Button ID="btnGetFromMysql" runat="server" Text="Hae palautteet Mysql" OnClick="btnGetFromMysql_Click" />
        <asp:Button ID="btnGiveFeedback" runat="server" Text="Anna palautetta" OnClick="btnGiveFeedback_Click" /> <br />
        <h2>Xml</h2>
        <asp:GridView ID="gvXml" runat="server"></asp:GridView>
        <h2>Mysql</h2>
        <asp:GridView ID="gvMysql" runat="server"></asp:GridView>
        <asp:Label ID="lblMessages" runat="server"></asp:Label>
    </div> 
    </form>
</body>
</html>
