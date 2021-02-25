<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="EShopOS.Web.Admin.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="secction">
        <div class="pr-title ">
                <h1 class="font-fantastic cl-dark">Panel de Control</h1>
             </div>
        <hr />
        <div class="row link-access">
            <div class="col-md-3 link-target">
                <asp:LinkButton ID="GoToProducts" runat="server" OnClick="GoToProducts_Click" CssClass="text-link-target">Ver productos</asp:LinkButton>
            </div>
            <div class="col-md-3 link-target">
                <asp:LinkButton ID="GoToOrders" runat="server" OnClick="GoToOrders_Click" CssClass="text-link-target">Ver Ordenes</asp:LinkButton>
            </div>
            <div class="col-md-3 link-target">
<<<<<<< HEAD
                <asp:LinkButton ID="GoToUsers" runat="server" OnClick="GoToUsers_Click" CssClass="text-link-target">Ver Usuarios</asp:LinkButton>
            </div>

=======
                <asp:LinkButton ID="GoToUsers" runat="server" OnClick="GoToOrders_Click" CssClass="text-link-target">Ver Usuarios</asp:LinkButton>
            </div>
>>>>>>> 4bc47852fc31575efc45bb816f6af3eb8e4325c9
        </div>
       
        
        
    </div>

</asp:Content>
 