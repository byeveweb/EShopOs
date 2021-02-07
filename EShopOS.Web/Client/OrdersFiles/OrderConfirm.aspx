<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="OrderConfirm.aspx.cs" Inherits="EShopOS.Web.Client.OrdersFiles.OrderDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <h1>Detalle de Carrito</h1>
    <hr />

    <%--
        Esto me sirve para revisar pedidos
        <asp:DropDownList ID="pdList" runat="server"></asp:DropDownList>
        --%>
    <h2>Datos de Entrega y usuario</h2>
    <asp:Label ID="txtUsername" runat="server" Text=""></asp:Label>
    <asp:Label ID="txtEmail" runat="server" Text=""></asp:Label>
    <asp:Label ID="txtPostalCode" runat="server" Text=""></asp:Label>
    <asp:Label ID="txtPostalAddress" runat="server" Text=""></asp:Label>
    <asp:Label ID="txtCity" runat="server" Text=""></asp:Label>
    <asp:Label ID="txtPhoneNumber" runat="server" Text=""></asp:Label>
    <asp:Label ID="txtNameAndSurname" runat="server" Text=""></asp:Label>


    <hr />
    <h2>Datos de la orden</h2>
    <asp:Label ID="txtOrderId" runat="server" Text=""></asp:Label>

    <asp:Label ID="txtCreateOrder" runat="server" Text=""></asp:Label>
    <asp:Label ID="txtOrderStatus" runat="server" Text=""></asp:Label>
    <asp:Label ID="txtUserId" runat="server" Text=""></asp:Label>

     <hr />
    <h2>Datos de los productos</h2>
     <hr />
    <table id="lista">
        <thead>
            <tr>
                <th>Nombre</th>
                <th width="500">Descripción</th>
                <th>Precio</th>
                <th>Stock</th>
                <th>Status</th>
                <th>Añadir</th>
                <th>Cantidad</th>
                <th>Eliminar</th>
            </tr>
        </thead>
                <tbody id="tbody" runat="server">            
        </tbody>
    </table>
    

    <hr />
    <h2>total</h2>
    <asp:Label ID="Total" runat="server" Text="" CssClass="card-title" Visible="True"></asp:Label>

    <hr />
    <asp:Button ID="buy_confirm" runat="server" Text="Confirmar compra" OnClick="buy_confirm_Click"/>
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
