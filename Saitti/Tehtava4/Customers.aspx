<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Customers.aspx.cs" Inherits="Tehtava4_Customers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" Runat="Server">
    <div style="float:left;margin-right:40px;">
        <asp:SqlDataSource ID="sdcCustomers" runat="server" ConnectionString="<%$ ConnectionStrings:Customers %>" SelectCommand="SELECT [astunnus], [asnimi], [yhteyshlo], [postitmp] FROM [asiakas]"></asp:SqlDataSource>
        <h1>SqlDatasourcen avulla</h1>
        <asp:GridView ID="gvCustomers" runat="server" DataSourceID="sdcCustomers">

        </asp:GridView>
    </div>
    <div style="float:left;">
        <h1>Luokan metodeilla</h1>
        <asp:GridView ID="gvCustomers2" runat="server">

        </asp:GridView>

    </div>
    
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" Runat="Server">
</asp:Content>

