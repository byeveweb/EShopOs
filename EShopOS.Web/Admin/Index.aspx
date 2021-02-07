<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="EShopOS.Web.Admin.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="secction">
        <div class="title">
            <h1>Panel de control</h1>
        </div>
        <div class="row link-access">
            <div class="col-md-5 link-target">
                <asp:LinkButton ID="GoToProducts" runat="server" OnClick="GoToProducts_Click" CssClass="text-link-target">Ver productos</asp:LinkButton>
            </div>
            <div class="col-md-5 link-target">
                <asp:LinkButton ID="GoToOrders" runat="server" OnClick="GoToOrders_Click" CssClass="text-link-target">Ver Ordenes</asp:LinkButton>
            </div>
        </div>
       
        
        
    </div>

</asp:Content>
