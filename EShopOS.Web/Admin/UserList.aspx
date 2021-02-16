<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UserList.aspx.cs" Inherits="EShopOS.Web.Admin.UserList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     
    <div class="secction">
        <div class="title2">
              <h2>Listado de Usuarios</h2>
        </div>
         <asp:Label ID="RoleName" runat="server" Text=""></asp:Label>
        <table class="table p-15" id="products">
          <thead>
            <tr>
              <th scope="col">Id</th>
              <th scope="col">Fecha de Creación</th>
              <th scope="col">Estado</th>
              <th scope="col">Usuario</th>
              <th scope="col">Editar</th>

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

