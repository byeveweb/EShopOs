<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ShoppingCartDetail.aspx.cs" Inherits="EShopOS.Web.Client.ShoppingCart.ShoppingCartDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Carrito de Compras</h1>
    <hr />
    <div>
    <asp:Label ID="lbUserId" runat="server" Text="Id del usuario:"></asp:Label>
        </div>
    <div>
    <asp:Label ID="lbProductID" runat="server" Text="Id del producto:"></asp:Label>
        </div>
    <div>

    <asp:Label ID="lbCantidad" runat="server" Text="Cantidad del producto:"></asp:Label></div>


</asp:Content>
