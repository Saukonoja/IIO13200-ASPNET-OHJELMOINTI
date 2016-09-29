<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="SQLexample.aspx.cs" Inherits="SQLexample" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" Runat="Server">
    <!-- Datasource -->
    <asp:SqlDataSource ID="srcMovies" runat="server" ConnectionString="<%$ ConnectionStrings:MoviesConnectionString %>" SelectCommand="SELECT [title], [director], [year], [url] FROM [Movies]"></asp:SqlDataSource>
    <!-- GW kontrolloi -->
    <asp:GridView runat="server" DataSourceID="srcMovies" HeaderStyle-BackColor="Blue" HeaderStyle-ForeColor="White" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="title" HeaderText="title" SortExpression="title" />
            <asp:BoundField DataField="director" HeaderText="director" SortExpression="director" />
            <asp:BoundField DataField="year" HeaderText="year" SortExpression="year" />
        </Columns>
<HeaderStyle BackColor="Blue" ForeColor="White"></HeaderStyle>
</asp:GridView >
    <!--elokuvien posterit näkyviin-->
    <asp:Repeater ID="Repeater1" runat="server" DataSourceID="srcMovies">
        <ItemTemplate>
            <h3><%# Eval("title") %></h3>
            <img src="<%# Eval("url") %>" alt="kuva puuttuu" width="200" />
        </ItemTemplate>
    </asp:Repeater>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" Runat="Server">
</asp:Content>

