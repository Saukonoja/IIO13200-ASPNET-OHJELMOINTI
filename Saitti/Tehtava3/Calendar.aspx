<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Calendar.aspx.cs" Inherits="Tehtava3_Calendar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Tänään on: <asp:Label ID="lblToday" runat="server"></asp:Label><br />
        Valittu päivä: <asp:Label ID="lblSelectedDay" runat="server"></asp:Label><br />
        Valitun päivän ja tämän päivän välillä on: <asp:Label ID="lblDifference" runat="server"></asp:Label><br />
        <asp:Button ID="btnPreviousYear" runat="server" Text="<< vuosi" OnClick="btnPreviousYear_Click" />
        <asp:Button ID="btnNextYear" runat="server" Text="vuosi >>" OnClick="btnNextYear_Click" /><br />
        <asp:Calendar ID="calendar" runat="server" OnSelectionChanged="calendar_SelectionChanged" AutoPostBack="True"></asp:Calendar> 
    </div>
    </form>
</body>
</html>
