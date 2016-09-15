<%@ Page Language="C#" AutoEventWireup="true" CodeFile="HaeOppilaatIlta.aspx.cs" Inherits="HaeOppilaatIlta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Oppilaat s.2016</h1>
        <div id="buttoset">
            <asp:Button ID="btnGet3" runat="server" Text="Hae 3 oppilasta" OnClick="btnGet3_Click" />
            <asp:Button ID="btnGetAll" runat="server" Text="Hae kaikki oppilaat" OnClick="btnGetAll_Click" />
            <asp:Button ID="btnGet4" runat="server" Text="Hae 4 oppilas oliota" OnClick="btnGet4_Click" />
        </div>
        <div id="data">
            <asp:GridView ID="gvStudents" runat="server" />
        </div>
        <div id="footer">
            <asp:Label ID="lblMessages" runat="server" />
        </div>
    </div>
    </form>
</body>
</html>
