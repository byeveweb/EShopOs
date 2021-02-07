<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ProductControl.ascx.cs" Inherits="EShopOS.Web.Controls.ProductControl" %>
<div class="col-md-5 margin-r-1 ">
    <div class="bg-white product-detail">
        <div class="box-product">
            <asp:Label ID="txtProductId" runat="server" Text="" CssClass="cl-pr-id"></asp:Label>
             - <asp:Label ID="txtProductStatus" runat="server" Text="" CssClass="cl-pr-id"></asp:Label>
        </div>
            <div class="pd-title font-fantastic font-size-25  margin-t-1 box-product">
                <asp:Label ID="txtNameProduct" runat="server" Text="" CssClass="card-title"></asp:Label>
            </div>
        <div class="image-product">
            <img src="https://dummyimage.com/600x400/000/fff" />
        </div>
        <div class="pd-title font-size-25 box-product border-product ">
            <h5>Precio:</h5>
            <asp:Label ID="txtPrice" runat="server" Text="" CssClass="price"></asp:Label>€
        </div>
 
        <div class="pd-title font-size-25 box-product border-product">
            <h5>Stock:</h5>
             <asp:Label ID="txtStock" runat="server" Text="" CssClass="price"></asp:Label>
        </div>

        <div class="pd-title font-size-25 box-product border-product ">
            <asp:Label ID="txtDescription" runat="server" Text="" CssClass="description-product"></asp:Label>
        </div>
        <form>
           <div class="form-group box-product title-select">
                <label for="QuantityProduct" class="margin-r-1">Cantidad</label>
                <asp:DropDownList ID="QuantityProduct" runat="server" CssClass="form-control">
                    <asp:ListItem Value="1">1</asp:ListItem>
                    <asp:ListItem Value="2">2</asp:ListItem>
                    <asp:ListItem Value="3">3</asp:ListItem>
                 </asp:DropDownList>
          </div>
        </form>
       <div class="box-product text-center">
        <asp:Button ID="AddCart" runat="server" Text="Añadir Al carrito" OnClick="AddCart_Click"  CssClass="btn-pink-light btn add" Visible="false"/>
       </div>
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




