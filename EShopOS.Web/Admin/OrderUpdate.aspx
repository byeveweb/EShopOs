<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="OrderUpdate.aspx.cs" Inherits="EShopOS.Web.Client.OrdersFiles.OrderCreate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

        
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
            <asp:HiddenField ID="txtId" runat="server" />


        <div class="secction">


                 <div class="title2">
                    <h2>Ver / Editar Orden</h2>
                 </div>

                <div class="p-15">

                        <div class="row">

                             <div class="col-md-6 bg-pink-light p-15 box-dates">

                                    <div class="title2 ">
                                           <h5>Datos de la Orden</h5>
                                    </div>

                                    <div class="p-1">
                                        <span class="label-one">Id de Orden: </span>
                                        <asp:Label ID="txtOid" runat="server" Text="" CssClass="label-two"></asp:Label>
                                    </div>

                                     <div class="p-1">
                                        <span class="label-one">Fecha de creación: </span>
                                        <asp:Label ID="txtODateCreation" runat="server" Text="" CssClass="label-two"></asp:Label>
                                    </div>
             
                                    <div class="form-group p-1">
                                        <asp:Label ID="StatusOrder" runat="server"  Text="Status Orden" AssociatedControlID="selStatusOrder" CssClass="label-one"></asp:Label>
                                        <asp:DropDownList ID="selStatusOrder" CssClass="form-control label-two" runat="server"></asp:DropDownList>
                                    </div>

                               </div>


                              <div class="col-md-6 bg-pink-medium-light p-15 box-dates ">

                                    <div class="title2 ">
                                           <h5>Datos de usuario</h5>
                                    </div>

                                    <div class="p-1">
                                        <span class="label-one">Id de Usuario: </span>
                                        <asp:Label ID="txtUId" runat="server" Text="" CssClass="label-two"></asp:Label>
                                    </div>

                                     <div class="p-1">
                                        <span class="label-one">Nombre: </span>
                                        <asp:Label ID="txtUName" runat="server" Text="" CssClass="label-two"></asp:Label>
                                    </div>

                                    <div class="p-1">
                                        <span class="label-one">Teléfono: </span>
                                        <asp:Label ID="txtUPhone" runat="server" Text="" CssClass="label-two"></asp:Label>
                                    </div>

                                   <div class="p-1">
                                        <span class="label-one">Email: </span>
                                        <asp:Label ID="txtUEmail" runat="server" Text="" CssClass="label-two"></asp:Label>
                                    </div>

                               </div>
                            </div>

                    <div class="row">
                         <div class="col-md-4 df-jf-start pr-button-up">
                            <asp:Button ID="closeOrder" runat="server" Text="Cerrar Orden" CssClass="btn-pink-dark btn-lg btn" OnClick="closeOrder_Click"/>
                        </div>
                        <div class="col-md-4 df-jf-start pr-button-up">
                            <asp:Button ID="processOrder" runat="server" Text="Procesar Orden" CssClass="btn-pink-dark btn-lg btn" OnClick="processOrder_Click"/>
                        </div>
                        <div class="col-md-4 df-jf-start pr-button-up">
                            <asp:Button ID="deleteOrder" runat="server" Text="Eliminar Orden" CssClass="btn-pink-dark btn-lg btn" OnClick="deleteOrder_Click"/>
                        </div>
                    </div>
                    
                        <div class="row"> 
                            <div class="title2 ">
                                 <h3>Detalle de la orden</h3>
                            </div>
                            <table class="table p-15" id="ordts">
                                      <thead>
                                        <tr>
                                          <th scope="col">Id</th>
                                          <th scope="col">Order_Id</th>
                                          <th scope="col">Producto</th>
                                          <th scope="col">Precio</th>
                                          <th scope="col">Status</th>
                                          <th scope="col">Cantidad</th>
                                          <th scope="col">Total</th>

                                        </tr>
                                      </thead>
                                          <tbody id="tbody" runat="server">
                                          </tbody>
                                        </table>

                        </div>
                    </div>
             <asp:Label ID="error" runat="server" Text=""></asp:Label>
                            <asp:Label ID="result" runat="server" Text=""></asp:Label>
            </div>


</asp:Content>
