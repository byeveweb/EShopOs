<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UserDetail.aspx.cs" Inherits="EShopOS.Web.Client.UserDetail.UserDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="secction">

             
     <div class="secction">

             <div class="bg-pink-dark pr-title">
                <h1 class="font-fantastic">Datos de usuario</h1>
             </div>


                <div class="p-15">

                        <div class="row">
                        <div class="col-md-12 bg-pink-light p-15 box-dates">

                                    <div class="title2 ">
                                           <h5>Datos de Usuario</h5>
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

                        </div>
                        <div class="row"> 
                                <div class="title2 ">
                                     <h3>Mis pedidos</h3>
                                </div>
                                <table class="table p-15" id="lista">
                                          <thead>
                                            <tr>
                                              <th scope="col">Id</th>
                                              <th scope="col">Fecha</th>
                                              <th scope="col">Estado</th>
                                              <th scope="col">Ver</th>


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

        </div>
</asp:Content>

