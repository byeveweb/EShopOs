<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductList.aspx.cs" Inherits="EShopOS.Web.Client.ProductList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="secction">
        <div class="pr-title ">
                <h1 class="font-fantastic cl-dark">Listado de productos</h1>
             </div>
        <hr />
    
           

        <table class="table p-15" id="products">
          <thead>
            <tr>
              <th scope="col">Id</th>
              <th scope="col">Nombre</th>
              <th scope="col">Precio</th>
              <th scope="col">Stock</th>
              <th scope="col">Status</th>
              <th scope="col">Editar</th>
              <th scope="col">Eliminar</th>

            </tr>
          </thead>
              <tbody id="tbody" runat="server">
              </tbody>
            </table>

            <div class="link-section">
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Admin/ProductDetailAndUpdate.aspx" CssClass="btn btn-pink-dark">Crear Nuevo Producto</asp:HyperLink>
        </div>

     </div>

     <script>
         $(document).ready(function () {

             $('.rm').on('click', function () {
                 alert("delete");
             })
         });
     </script>
</asp:Content>
