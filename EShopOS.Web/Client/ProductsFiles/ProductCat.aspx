 <%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductCat.aspx.cs" Inherits="EShopOS.Web.Client.ProductsFiles.ProductDtl" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="secction">
        <div class="row">
            <div class="bg-pink-dark pr-title">
                <h1 class="font-fantastic">Catálogo</h1>
             </div>
             <div class="row margin-b-1 bb-pink-dark" runat="server" id="total" visible="false">
                    <div class="col-md-10 df-jf pr-button-up">
                       <h2>Total: </h2>
                       <asp:Label ID="txtTotalismo" runat="server" Text="" CssClass="h2"></asp:Label> 
                    </div>
                
                    <div ID="alert" class="col-md-10" runat="server" Visible="true">
                        <div  class="col-md-10 alert alert-danger font-size-15 pr-button-up" >
                            <p>¡Antención! Usted no está logueado</p>
                        </div>
                    </div>
                    <div class="col-md-2 df-jf-start pr-button-up">
                        <asp:Button ID="Buy" runat="server" Text="Comprar" OnClick="Buy_Click" CssClass="add-to-cart btn-pink-dark btn-lg btn" Enabled="False"/>
                    </div>
                </div>
            <asp:PlaceHolder ID="carro" runat="server"></asp:PlaceHolder>
         </div>
    </div>
    <script>
        $(document).ready(function () {

            $('.add').on('click', function () {

                var productId = $(this).data("id");
                var quantity = $($(this.parentElement.parentElement.parentElement).find(".quantity")[0]).val();


                $.ajax({
                    type: "POST",
                    url: "https://localhost:44328/Controls/ShopingCart.asmx/AddCart",
                    data: { productId: productId, quantity: quantity },
                    success: function (data) {
                        $("#carrito").text(data)
                        console.log(data);
                    },
                    error: function (XMLHttpRequest, textStatus, errorThrown) {
                        alert("some error");
                    }

                });
            });
        });

    </script>

     
</asp:Content>




