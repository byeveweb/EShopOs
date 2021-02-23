<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductDetail.aspx.cs" Inherits="EShopOS.Web.Client.ProductsFiles.ProductDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="secction">
        <div class="row">
            <div class="bg-pink-dark pr-title">
                <h1 class="font-fantastic">Producto</h1>
             </div>
        <div class="col-md-12 no-pdd product-detail margin-b-1">
        <div class="bg-white">
            <div class="row no-mrg " >
                <div class="col-md-4 no-pdd" >
                    <div class="image-product">
                        <asp:Image ID="txtImageUrl" runat="server" ImageUrl="~/Content/Images/1.jpg" />
                    </div>
                </div>

                <div class="col-md-8">
                    <div class="row no-mrg df-jf-start" >
                            <div class="col-md-8 no-pdd " >
                                <div class="pd-title tlt-product margin-15">
                                <asp:Label ID="txtNameProduct" runat="server" Text="" CssClass="card-title"></asp:Label>
                                </div>
                            </div>
                            <div class="col-md-4 no-pdd" >
                                <div class="pd-title margin-15 text-right">
                                    <asp:Label ID="txtProductId" runat="server" Text="" CssClass="cl-pr-id"></asp:Label> | 
                                     <asp:Label ID="txtProductStatus" runat="server" Text="" CssClass="cl-pr-id"></asp:Label> | 
                                    <asp:Label ID="txtStock" runat="server" Text="" CssClass="cl-pr-id"></asp:Label>
              
                                </div>
                            </div>
                      </div>
                    <div class="row no-mrg df-jf-start" >
                            <div class="col-md-4">
                                <div class="pd-title">
                                    <h5>P.V.P:</h5>
                                    <asp:Label ID="txtPrice" runat="server" Text="" CssClass="price"></asp:Label>€
                                </div>
                            </div>

                       </div>
                    <div class="row no-mrg df-jf-start" >
                                <div class=" pd-title margin-15">
                                    <asp:Label ID="txtDescription" runat="server" Text="" CssClass="description-product"></asp:Label>
                                </div>
                            </div>
                    <asp:Button ID="eliminarPro" runat="server" Text="Eliminar producto" CssClass="btn-pink-light btn" OnClick="eliminarPro_Click"/>
                </div>
             </div>
              

            </div>
                </div><asp:Label ID="error" runat="server" Text=""></asp:Label>
                            <asp:Label ID="result" runat="server" Text=""></asp:Label>
            </div>
        </div>
</asp:Content>

