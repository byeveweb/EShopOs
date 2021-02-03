<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ProductControl.ascx.cs" Inherits="EShopOS.Web.Controls.ProductControl" %>





<div class="card col-md-4">
  <div class="card-body">
        <asp:Label ID="txtNameProduct" runat="server" Text="" CssClass="card-title"></asp:Label>
    </div>
    <div class="card-text">
        <asp:Label ID="txtDescription" runat="server" Text="" CssClass="card-text"></asp:Label>
       </div>
  <ul class="list-group list-group-flush">
      
       <asp:Label ID="ProductId" runat="server" Text="" CssClass="list-group-item"></asp:Label>
      <p>Precio</p>

      <asp:Label ID="txtPrice" runat="server" Text="" CssClass="list-group-item"></asp:Label>
      <p>Stock</p>

        <asp:Label ID="txtStock" runat="server" Text="" CssClass="list-group-item"></asp:Label>
      <p>Disponibilidad</p>

        <asp:Label ID="txtProductStatus" runat="server" Text="" CssClass="list-group-item"></asp:Label>
  </ul>
            <asp:DropDownList ID="type" runat="server">
            <asp:ListItem Value="1">1</asp:ListItem>
            <asp:ListItem Value="2">2</asp:ListItem>
            <asp:ListItem Value="3">3</asp:ListItem>
        </asp:DropDownList>
  <div class="card-text">
      <asp:Button ID="Button1" runat="server" Text="Añadir Al carrito" OnClick="Button1_Click"  CssClass="btn btn-primary add"/>
  </div>
</div>

<script>
import { each } from "jquery";
         $('.add').on('click', function () {
             var productId = $(this).data("shopping");
             $.ajax({
                 type: "POST",
                 url: "../Controls/ShoppingCartControl.ascx",
                 data: {  },
                 success: function (data) {
                     $.each(response, function (index, emp) {
                         $('#carrito').append('<p>Id: ' + emp.ID + '</p>' +
                             '<p>Id: ' + emp.Name + '</p>');
                     }); 
                 }
             });
         });
</script>




