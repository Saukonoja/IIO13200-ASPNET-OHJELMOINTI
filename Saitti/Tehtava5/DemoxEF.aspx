<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="DemoxEF.aspx.cs" Inherits="Tehtava5_DemoxEF" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" Runat="Server">
    <div style="float:left;">
        <asp:Button ID="btnGetAllCustomers" Text="Hae kaikki asiakkaat" OnClick="btnGetAllCustomers_Click" runat="server" />
        <asp:DropDownList ID="ddlCountries" AutoPostBack="true" runat="server"></asp:DropDownList>
        <asp:Button ID="btnGetFromSelected" Text="Hae valitusta maasta" OnClick="btnGetFromSelected_Click" runat="server" />
        <asp:Button ID="btnGetByCountry" Text="Hae maittain" OnClick="btnGetByCountry_Click" runat="server" />
        <asp:GridView ID="gvCustomers" runat="server" />
        <asp:Label ID="lblMessages" runat="server" />
    </div>
    <div style="float:left;">
        <asp:Label ID="lblByCountry" runat="server"></asp:Label>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" Runat="Server">
</asp:Content>

