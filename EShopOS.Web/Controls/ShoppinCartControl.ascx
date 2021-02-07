<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ShoppinCartControl.ascx.cs" Inherits="EShopOS.Web.Controls.ShoppinCartControl" %>
<div id="carrito" class="row">
    <asp:Label ID="txtIdCart" runat="server" Text="" CssClass="card-title" Visible="False"></asp:Label>
    <asp:Label ID="txtUserId" runat="server" Text="" CssClass="card-title" Visible="False"></asp:Label>
    <div class="lineacarrito title-select">
        <div class="texto-carrito margin-r-1">
            <asp:Label ID="txtProductId" runat="server" Text="" CssClass=""></asp:Label> -
        </div>
          
        <div class="texto-carrito margin-r-1">
            <asp:Label ID="txtProductName" runat="server" Text="" CssClass="texto-carrito"></asp:Label> -
          </div>
      
        <div class="texto-carrito margin-r-1">
            <asp:Label ID="txtProductPrice" runat="server" Text="" CssClass="texto-carrito"></asp:Label>€ /
        </div>
        
        <div class="texto-carrito margin-r-1">
            <asp:Label ID="txtQuantity" runat="server" Text="" CssClass="card-title"></asp:Label> und.
            </div>
      </div>
    </div>