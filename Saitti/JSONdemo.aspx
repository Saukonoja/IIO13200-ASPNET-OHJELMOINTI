<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="JSONdemo.aspx.cs" Inherits="JSONdemo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" Runat="Server">
    <asp:Button ID="btnGet" runat="server" Text="Hae Json-teksti" OnClick="btnGet_Click"/>
    <asp:Button ID="btnGetPerson" runat="server" Text="Hae Json-teksti ja muuta olikosi" OnClick="btnGetPerson_Click"/>
    <asp:Button ID="btnGetPolitics" runat="server" Text="Hae Json-teksti ja muuta oliokokoelmaksi" OnClick="btnGetPolitics_Click" />
    <asp:Literal ID="ltReslut" runat="server" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" Runat="Server">
</asp:Content>

