<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductList.aspx.cs" Inherits="EShopOS.Web.Client.ProductList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Admin/CreateUpdate.aspx" CssClass="btn btn-primary">Nuevo Producto</asp:HyperLink>
    <link href="https://cdn.datatables.net/1.10.23/css/jquery.dataTables.min.css" rel="stylesheet" />
    <hr />

    <table id="products">
        <thead>
            <tr>
                <th>Nombre</th>
                <th>Descripción</th>
                <th>Precio</th>
                <th>Stock</th>
                <th>Status</th>
            </tr>
        </thead>
                <tbody id="tbody" runat="server">            
        </tbody>
    </table>
    <script src="https://cdn.datatables.net/1.10.23/js/jquery.dataTables.min.js"></script>
    <script>
        <%: Scripts.Render("~/bundles/datatables") %>
        <script type="text/javascript">
            $(document).ready(function() {
                $('#example').DataTable({
                    "oLanguage": { "sUrl": "//cdn.datatables.net/plug-ins/1.10.7/i18n/Spanish.json" }
                });
        } );
    </script>


</asp:Content>
