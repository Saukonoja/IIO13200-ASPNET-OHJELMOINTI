<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Finnkino.aspx.cs" Inherits="Tehtava8_Finnkino" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div >
        <div style="float:left;">
            <asp:ListBox ID="lbTheaters" runat="server" AutoPostBack="true" OnSelectedIndexChanged="lbTheaters_SelectedIndexChanged" Height="480"></asp:ListBox><br />
        
        </div>       
        
        <div id="movies" runat="server" style="width:1200px; max-height:370px; float:left;">
            

        </div>
        
    </div>
    </form>
    <footer>
        <asp:Label ID="lblMessages" runat="server" Width="100%"></asp:Label>
    </footer>
</body>
    
</html>
