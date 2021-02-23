<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="OrderList.aspx.cs" Inherits="EShopOS.Web.Admin.OrderList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <div class="secction">
       <div class="pr-title ">
                <h1 class="font-fantastic cl-dark">Listado de ordenes</h1>
             </div>
        <hr />

        <table class="table p-15" id="products">
          <thead>
            <tr>
              <th scope="col">Id</th>
              <th scope="col">Fecha de creación</th>
              <th scope="col">Estado</th>
              <th scope="col">Usuario</th>
              <th scope="col">Nº De Artículos</th>
              <th scope="col">Ver/Editar</th>

            </tr>
          </thead>
              <tbody id="tbody" runat="server">              </tbody>
            </table>
         <div>
         <asp:Label ID="error" runat="server" Text=""></asp:Label>
                            <asp:Label ID="result" runat="server" Text=""></asp:Label>
    </div>
     </div>
   


</asp:Content>

