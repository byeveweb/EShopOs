 <%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductCat.aspx.cs" Inherits="EShopOS.Web.Client.ProductsFiles.ProductDtl" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <h2 class="font-fantastic">Catálogo</h2>
        <hr />
            <div class="row margin-b-1" runat="server" id="total" visible="false">
                <div class="col-md-10 df-jf">
                   <h3>Total: </h3>
                   <asp:Label ID="txtTotalismo" runat="server" Text="" CssClass="h3 bold"></asp:Label> 
                </div>
                
                <div ID="alert" class="col-md-10" runat="server" Visible="true">
                    <div  class="col-md-10 alert alert-danger font-size-15" >
                        <p>¡Antención! Usted no está logueado</p>
                    </div>
                </div>
                <div class="col-md-2 df-jf-start">
                    <asp:Button ID="Buy" runat="server" Text="Comprar" OnClick="Buy_Click" CssClass="add-to-cart btn-pink-dark btn-lg btn" Enabled="False"/>
                </div>
            </div>
        <asp:PlaceHolder ID="carro" runat="server"></asp:PlaceHolder>
     </div>
    <script>
        $(document).ready(function () {
            $('.addCart').on('click', function () {
                var productId = $(this).data("id");
                var quantity = $($(this.parentElement.parentElement.parentElement).find(".quantity")[0]).val();


                $.ajax({
                    type: "POST",
                    url: "https://localhost:44328/Controls/ShopingCart.asmx/AddCart",
                    data: { productId: productId, quantity: quantity },
                    success: function (data) {
                        $("#carrito").children(".lineacarrito").text(data)
                    },
                    error: function (XMLHttpRequest, textStatus, errorThrown) {
                        alert("some error");
                    }

                });
            });
        });

    </script>

     
</asp:Content>




