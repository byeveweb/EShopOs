<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="OrderDetail.aspx.cs" Inherits="EShopOS.Web.Client.OrdersFiles.OrderDetail1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<<<<<<< HEAD

           <div class="secction">


                 
             <div class="bg-success pr-title">
                <h1 class="font-fantastic">Gracias por confiar en nosotros</h1>
             </div>

                <div class="p-15">

                        <div class="row">

                             <div class="col-md-9 bg-pink-light p-15 box-dates success">

                                    <div class="title2 ">
                                           <h5>Datos de la Orden</h5>
                                    </div>

                                    <div class="p-1">
                                        <span class="label-one">Id de Orden: </span>
                                        <asp:Label ID="txtOrderId" runat="server" Text="" CssClass="label-two"></asp:Label>
                                    </div>

                                     <div class="p-1">
                                        <span class="label-one">Fecha de creación: </span>
                                        <asp:Label ID="txtCreateOrder" runat="server" Text="" CssClass="label-two"></asp:Label>
                                    </div>
             
                                    <div class="p-1">
                                        <asp:Label ID="StatusOrder" runat="server"  Text="Status Orden" CssClass="label-one"></asp:Label>
                                        <asp:Label ID="txtOrderStatus" runat="server" Text="" CssClass="label-two"></asp:Label>
                                    </div>
                                 
                                 </div>
                                 

                            <div class="col-md-3 bg-pink-light p-15 box-dates">
                                <div class="p-1">
                                 <span class="h2">Total: </span>
                                    <asp:Label ID="txtTotalismo" runat="server" Text="" CssClass="h2" Visible="True"></asp:Label>
                                </div>
                                </div>
                             
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
                                          <th scope="col">Producto</th>
                                          <th scope="col">Precio</th>
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
=======
    <div class="secction">

             <div class=" pr-title">

             </div>
        <div class="bg-pink-dark pr-title">
                <h1 class="font-fantastic">Gracias por su compra</h1>
                <asp:HyperLink ID="pdetail" runat="server" CssClass="link"NavigateUrl="~/Client/ProductFile/ProductCat.aspx">Volver >></asp:HyperLink>
             </div>
        <div class=" pr-title">

             </div>
        </div>
>>>>>>> 4bc47852fc31575efc45bb816f6af3eb8e4325c9
</asp:Content>
