<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Ikkuna.aspx.cs" Inherits="Tehtava1_Ikkuna" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblWinWidth" runat="server" Text="Ikkunan leveys (mm):"></asp:Label>
            <asp:TextBox ID="txtWinWidth" runat="server"></asp:TextBox><br />
            <br />
            <asp:Label ID="lblWinHeight" runat="server" Text="Ikkunan korkeus (mm):"></asp:Label>
            <asp:TextBox ID="txtWinHeight" runat="server"></asp:TextBox><br />
            <br />
            <asp:Label ID="lblFrWidth" runat="server" Text="Karmipuun leveys (mm):"></asp:Label>
            <asp:TextBox ID="txtFrWidth" Text="45" runat="server"></asp:TextBox><br />
            <br />
            <asp:Button ID="btnCalculate" runat="server" Text="Laske tarjoushinta" OnClick="btnCalculate_Click" /><br />
            <br />
            <asp:Label ID="lblWinArea" runat="server" Text="Ikkunan pinta-ala:"></asp:Label>
            <asp:Label ID="lblAreaResult" runat="server" Text=""></asp:Label><br />
            <br />
            <asp:Label ID="lblFrGirth" runat="server" Text="Karmin piiri:"></asp:Label>
            <asp:Label ID="lblGirthResult" runat="server" Text=""></asp:Label><br />
            <br />
            <asp:Label ID="lblPrice" runat="server" Text="Tarjoushinta (ilman ALV):"></asp:Label>
            <asp:Label ID="lblPriceResult" runat="server" Text=""></asp:Label><br />
            <br />
            <asp:Label ID="lblMessage" runat="server" Text="" Font-Bold="True"></asp:Label>
        </div>
    </form>
</body>
</html>
