<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="OrderConfirm.aspx.cs" Inherits="EShopOS.Web.Client.OrdersFiles.OrderDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
     <div class="secction">

             <div class="bg-pink-dark pr-title">
                <h1 class="font-fantastic">Resumen</h1>
             </div>


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
                            <div class="col-md-4">
                                <hr />
                            <h2>total:</h2>

                            <asp:Label ID="txtTotalismo" runat="server" Text="" CssClass="h2" Visible="True"></asp:Label>

                      <hr />
                            <asp:Button ID="buy_confirm" runat="server" Text="Confirmar" OnClick="buy_confirm_Click" CssClass="btn btn-pink-dark"/>
                  
                            </div>
                            </div>
                    </div>
    
    
    <div class="p-15">
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
                                              <th scope="col">Ver</th>
                                              <th scope="col">Eliminar</th>


                                            </tr>
                                          </thead>
                                              <tbody id="tbody" runat="server">
                                              </tbody>
                                  </table>

                            </div>
        </div>
                         </div>

</asp:Content>
