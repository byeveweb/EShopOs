<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="OrderCreate.aspx.cs" Inherits="EShopOS.Web.Client.OrdersFiles.OrderCreate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>CrearOrder</h2>
    <hr />
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
    <asp:HiddenField ID="txtId" runat="server" />
    <div class="form-group">
        <asp:Label ID="fechaOrder" runat="server" Text="Date" AssociatedControlID="txtfechaOrder"></asp:Label>
        <asp:TextBox ID="txtfechaOrder" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Campo obligatorio" ControlToValidate="txtfechaOrder" Text="Campo obligatorio"></asp:RequiredFieldValidator>
    </div>
     <div class="form-group">
        <asp:Label ID="UsuarioOrder" runat="server" Text="User" AssociatedControlID="userList"></asp:Label>
         <asp:DropDownList ID="userList" runat="server"></asp:DropDownList>
    </div>
    <div class="form-group">
        <asp:Label ID="StatusOrder" runat="server" Text="Disponibilidad de orer" AssociatedControlID="selStatusOrder"></asp:Label>
             <asp:DropDownList ID="selStatusOrder" runat="server"></asp:DropDownList>
             
    </div>
        <div class="form-group">
        <asp:Label ID="AllProducts" runat="server" Text="todos los productos" AssociatedControlID="selProduct"></asp:Label>
             <asp:DropDownList ID="selProduct" runat="server"></asp:DropDownList>
                <asp:Button ID="Button1" runat="server" Text="añadir" OnClick="Button1_Click" />
    </div>

    
        <div class="form-group">
        <asp:Label ID="PricePro" runat="server" Text="todos los productos" AssociatedControlID="priceProduct"></asp:Label>
              <asp:TextBox ID="priceProduct" runat="server" AutoPostBack="True"></asp:TextBox>
    </div>
    <div class="form-group">
        <asp:Label ID="Label1" runat="server" Text="todos los productos" AssociatedControlID="cantidad"></asp:Label>
              <asp:TextBox ID="cantidad" runat="server"></asp:TextBox>
    </div>
    <div class="form-group">
        <asp:Label ID="Label2" runat="server" Text="todos los productos" AssociatedControlID="total"></asp:Label>
              <asp:TextBox ID="total" runat="server"></asp:TextBox>
    </div>
      <div class="form-group">
          <asp:Button ID="btnSubmit" runat="server" Text="Crear Order" OnClick="btnSubmit_Click"/>
    </div>

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
