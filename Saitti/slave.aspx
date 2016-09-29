<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="slave.aspx.cs" Inherits="slave" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <title>Slave to MasterPage</title>
    <style>
        img {
            width:100%;
            height:auto;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" Runat="Server">
    <div class="w3-container w3-blue">
        <h1>Hieno heading 1</h1>
        <p>hieno p</p>
    </div>
    <div class="w3-row-padding">
        <div class="w3-third w3-light-grey">
            <h2>Heino heading 2</h2>
            <p>hienoa p lorem ipsum dolor estlorem ipsum dolor estlorem ipsum dolor estlorem ipsum dolor estlorem ipsum dolor estlorem ipsum dolor estlorem ipsum dolor est</p>
        </div>
        <div class="w3-third">
            <img src="http://www.w3schools.com/css/trolltunga.jpg" />
            
        </div>

    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" Runat="Server">
</asp:Content>

