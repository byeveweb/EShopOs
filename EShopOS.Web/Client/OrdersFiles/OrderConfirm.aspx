<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="OrderConfirm.aspx.cs" Inherits="EShopOS.Web.Client.OrdersFiles.OrderDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
     <div class="secction">


                 <div class="title2">
                    <h2>Confirmación orden de Compra</h2>
                 </div>

                <div class="p-15">

                        <div class="row">


                              <div class="col-md-6 bg-pink-light p-15 box-dates">

                                    <div class="title2 ">
                                           <h5>Datos de Entrega</h5>
                                    </div>

                                      <div class="p-05">
                                            <span class="label-one">Nombre: </span>
                                           <asp:Label ID="txtUsername" runat="server" Text="" CssClass="label-two"></asp:Label>
                                    </div>

                                    <div class="p-05">
                                        <span class="label-one">Email: </span>
                                       <asp:Label ID="txtEmail" runat="server" Text=""  CssClass="label-two" ></asp:Label>
                                    </div>
                                    <div class="p-05">
                                        <span class="label-one">Teléfono: </span>
                                           <asp:Label ID="txtPhoneNumber" runat="server" Text="" CssClass="label-two"></asp:Label>
                                    </div>
                                    <div class="p-05">
                                        <span class="label-one">Dirección: </span>
                                           <asp:Label ID="txtPostalAddress" runat="server" Text="" CssClass="label-two"></asp:Label>
                                    </div>

                                    <div class="p-05">
                                        <span class="label-one">Ciudad: </span>
                                           <asp:Label ID="txtCity" runat="server" Text="" CssClass="label-two"></asp:Label>
                                    </div>

                                     <div class="p-05">
                                        <span class="label-one">Código Postal: </span>
                                        <asp:Label ID="txtPostalCode" runat="server" Text="" CssClass="label-two"></asp:Label>
                                    </div>
             

                               </div>

                            
                              <div class="col-md-6 bg-pink-medium-light p-15 box-dates">

                                    <div class="title2 ">
                                           <h5>Datos de la Orden</h5>
                                    </div>

                                    <div class="p-1">
                                            <span class="label-one">Id de la Orden: </span>
                                            <asp:Label ID="txtOrderId" runat="server" Text=""></asp:Label>
                                    </div>
                                  <div class="p-1">
                                            <span class="label-one">Fecha: </span>
                                            <asp:Label ID="txtCreateOrder" runat="server" Text=""></asp:Label>
                                    </div>
                                  <div class="p-1">
                                            <span class="label-one">Estado: </span>
                                              <asp:Label ID="txtOrderStatus" runat="server" Text=""></asp:Label>
                                    </div>
                                </div>
                            </div>
                    </div>
    <%--
        Esto me sirve para revisar pedidos
        <asp:DropDownList ID="pdList" runat="server"></asp:DropDownList>
        --%>
    
    
    
                            <div class="row"> 
                            <div class="title2 ">
                                 <h3>Datos de los productos</h3>
                            </div>
                            <table class="table p-15" id="lista">
                                      <thead>
                                        <tr>
                                          <th scope="col">Id</th>
                                          <th scope="col">Nombre</th>
                                          <th scope="col">Precio</th>
                                          <th scope="col">Cantidad</th>
                                          <th scope="col">Total</th>
                                          <th scope="col">Eliminar</th>


                                        </tr>
                                      </thead>
                                          <tbody id="tbody" runat="server">
                                          </tbody>
                              </table>

                        </div>
    




 
<%--    <table id="list">
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
    </table>--%>
    

    <hr />
    <h2>total</h2>
    <asp:Label ID="Total" runat="server" Text="" CssClass="card-title" Visible="True"></asp:Label>

    <hr />
    <asp:Button ID="buy_confirm" runat="server" Text="Confirmar compra" OnClick="buy_confirm_Click"/>
         </div>
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
