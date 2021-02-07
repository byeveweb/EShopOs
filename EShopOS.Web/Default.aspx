<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EShopOS.Web._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1 class="text-center font-fantastic">¡Bienvenido!</h1>
        <h3 class="text-center font-fantastic">A la tienda de las maravillas</h3>
        <asp:Button ID="CatAccss" runat="server" Text="Acceder a la tienda" CssClass="btn btn-lg btn-block btn-pink-light" OnClick="CatAccss_Click" />
     
    </div>



</asp:Content>
