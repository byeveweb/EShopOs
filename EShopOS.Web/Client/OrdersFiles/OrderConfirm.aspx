<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="OrderConfirm.aspx.cs" Inherits="EShopOS.Web.Client.OrdersFiles.OrderDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
     <div class="secction">

             <div class="bg-pink-dark pr-title">
                <h1 class="font-fantastic">Resumen</h1>
             </div>
<<<<<<< HEAD

=======
>>>>>>> 4bc47852fc31575efc45bb816f6af3eb8e4325c9


                <div class="p-15">

                        <div class="row">

                              <div class="col-md-4 bg-pink-light p-15 box-dates">

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

                               <div class="col-md-4 bg-pink-medium-light p-15 box-dates">

                                    <div class="title2 ">
                                           <h5>Datos de la Orden</h5>
                                    </div>

                                    <div class="p-1">
                                            <span class="label-one">Id de la Orden: </span>
<<<<<<< HEAD
                                            <asp:Label ID="txtOrderId" runat="server" Text="" CssClass="idsOrder"></asp:Label>
=======
                                            <asp:Label ID="txtOrderId" runat="server" Text=""></asp:Label>
>>>>>>> 4bc47852fc31575efc45bb816f6af3eb8e4325c9
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
                            <div class="col-md-4">
                                <hr />
                            <h2>total:</h2>

                            <asp:Label ID="txtTotalismo" runat="server" Text="" CssClass="h2" Visible="True"></asp:Label>

                      <hr />
<<<<<<< HEAD
                            <asp:Button ID="buy_confirm" runat="server" Text="Pagar" OnClick="buy_confirm_Click" CssClass="btn btn-pink-dark" Enable="true"/>

=======
                            <asp:Button ID="buy_confirm" runat="server" Text="Confirmar" OnClick="buy_confirm_Click" CssClass="btn btn-pink-dark"/>
                  
>>>>>>> 4bc47852fc31575efc45bb816f6af3eb8e4325c9
                            </div>
                            </div>
                    </div>
    
    
<<<<<<< HEAD
                <div class="p-15">
=======
    <div class="p-15">
>>>>>>> 4bc47852fc31575efc45bb816f6af3eb8e4325c9
                            <div class="row"> 
                                <div class="title2 ">
                                     <h3>Datos de los productos</h3>
                                </div>
<<<<<<< HEAD
                                <asp:Label ID="txtIdOd" runat="server" Text="" CssClass="h2" Visible="True"></asp:Label>
=======
>>>>>>> 4bc47852fc31575efc45bb816f6af3eb8e4325c9
                                <table class="table p-15" id="lista">
                                          <thead>
                                            <tr>
                                              <th scope="col">Id</th>
                                              <th scope="col">Nombre</th>
                                              <th scope="col">Precio</th>
                                              <th scope="col">Cantidad</th>
                                              <th scope="col">Total</th>
                                              <th scope="col">Ver</th>
                                              <th scope="col">Eliminar</th>


                                            </tr>
                                          </thead>
                                              <tbody id="tbody" runat="server">
                                              </tbody>
                                  </table>
<<<<<<< HEAD

                            </div>
        </div>
                            <asp:Label ID="error" runat="server" Text=""></asp:Label>
                            <asp:Label ID="result" runat="server" Text=""></asp:Label>
                         </div>

    
        <div>
            <asp:Button ID="trae" runat="server" Text="Eliminar Todos los productos" CssClass="btn btn-pink-dark" OnClick="del2_Click"/>

            <asp:Label ID="lblResultado" runat="server" CssClass="label" />
        </div>
 
    <script>
        $(document).ready(function () {

            $('.elim').on('click', function (e) {

 

                var orderId = $(this).data(".idsOrder");

                $.ajax({
                    type: "POST",
                    url: "OrderConfirm.aspx/RemoveCartItem",
                    data: { orderId: 85 },
                    contentType: "application/json; charset=utf-8",
                    success: function (data) {
                        $("#lista").text(data);
                    },
                    error: function (XMLHttpRequest, textStatus, errorThrown) {
                        alert("some error");
                    }

                });
            });
        });
       
    </script>
=======

                            </div>
        </div>
                         </div>
>>>>>>> 4bc47852fc31575efc45bb816f6af3eb8e4325c9

</asp:Content>
