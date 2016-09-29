<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="XMLexample.aspx.cs" Inherits="XMLexample" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" Runat="Server">
    <!--XMLdataSource määrittely-->
    <asp:XmlDataSource ID="srcMovies" runat="server" DataFile="~/App_Data/Movies.xml" XPath="//Movie"></asp:XmlDataSource>
    <!-- GridView-kontrolli esittää datan -->
    <asp:GridView runat="server" DataSourceID="srcMovies" HeaderStyle-BackColor="Blue" HeaderStyle-ForeColor="White"></asp:GridView >
    <h1>Hienot elokuvat</h1>
    <!-- Datan esittämine HTML:ssä-->
    <h1>Elokuvat listattnua</h1>
    <asp:Repeater ID="Repeater1" runat="server" DataSourceID="srcMovies">
        <HeaderTemplate>
            <table border="1" style="width:50%">
                <tr>
                    <td>Elokuva</td>
                    <td>Ohjaaja</td>
                </tr>
            </table>
        </HeaderTemplate>
        <ItemTemplate>
            <tr>
                <td><%# Eval("Name") %></td><td><%# Eval("Director") %></td>
            </tr>
        </ItemTemplate>
        <ItemTemplate>
            <p><%# Eval("Name") %> ohjaaja: <%# Eval("Director") %></p>
        </ItemTemplate>
    </asp:Repeater>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" Runat="Server">
</asp:Content>

