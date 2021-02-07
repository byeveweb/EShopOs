 <%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductCat.aspx.cs" Inherits="EShopOS.Web.Client.ProductsFiles.ProductDtl" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <h2 class="font-fantastic">Catálogo</h2>
        <hr />
            <div class="row margin-b-1">
                
                <div class="col-md-10">
                    <div ID="alert" runat="server" class="col-md-10 alert alert-danger font-size-15" Visible="true">
                        <p>¡Antención! Usted no está logueado</p>
                    </div>
                </div>
                <div class="col-md-2 df-jf-start">
                    <asp:Button ID="Buy" runat="server" Text="Comprar" OnClick="Buy_Click" CssClass="add-to-cart btn-pink-dark btn-lg btn" Enabled="False"/>
                </div>
            </div>
     </div>
     
</asp:Content>




