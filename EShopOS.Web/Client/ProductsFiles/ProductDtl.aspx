 <%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductDtl.aspx.cs" Inherits="EShopOS.Web.Client.ProductsFiles.ProductDtl" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Catálogo</h2>
    <hr />
    <asp:Label ID="result" runat="server"></asp:Label>
    <asp:HiddenField ID="Id" runat="server" />
    <asp:Button ID="Button1" runat="server" Text="Comprar" OnClick="Button1_Click" CssClass="add-to-cart"/>
     
</asp:Content>




