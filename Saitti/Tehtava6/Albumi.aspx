<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Albumi.aspx.cs" Inherits="Tehtava6_Albumi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" Runat="Server">
    <img src="" id="albumImage" runat="server"/>
    <div id="albumInfo" style="font-size:20px;font-weight:bold" runat="server"></div>
    <div style="font-size:20px;font-weight:bold">Kappaleet levyllä:</div>
    <div id="albumSongs" style="font-size:18px;" runat="server"></div>
    <a href="Kuappa.aspx" runat="server">Takaisin</a>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" Runat="Server">
</asp:Content>

