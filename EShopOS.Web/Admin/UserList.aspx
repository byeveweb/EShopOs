<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UserList.aspx.cs" Inherits="EShopOS.Web.Admin.UserList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     
    <div class="secction">
        <div class="pr-title ">
                <h1 class="font-fantastic cl-dark">Listado de usuarios</h1>
             </div>
        <hr />
         <asp:Label ID="RoleName" runat="server" Text=""></asp:Label>
        <table class="table p-15" id="products">
          <thead>
            <tr>
              <th scope="col">Id</th>
              <th scope="col">Ciudad</th>
              <th scope="col">Email</th>
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

