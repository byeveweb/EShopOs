<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductDtl.aspx.cs" Inherits="EShopOS.Web.Client.ProductsFiles.ProductDtl" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Producto es: </h2>
    <hr />
    <asp:HiddenField ID="txtId" runat="server" />
    <asp:Label ID="txtNombreProducto" runat="server" Text="txtNombreProducto"></asp:Label>
    <asp:TextBox ID="txtNameProduct" runat="server" Text=""></asp:TextBox>
</asp:Content>

