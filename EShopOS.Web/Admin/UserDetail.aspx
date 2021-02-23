<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UserDetail.aspx.cs" Inherits="EShopOS.Web.Admin.UserDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="secction">
        <div class="pr-title ">
                <h1 class="font-fantastic cl-dark">Detalle de Usuario</h1>
             </div>
        <hr />
        <div class="row">
             <div class="col-md-6 bg-pink-medium-light p-15 ">

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
                                    <div class="p-1">
                                        <span class="label-one">Ciudad: </span>
                                        <asp:Label ID="txtUCity" runat="server" Text="" CssClass="label-two"></asp:Label>
                                    </div>
                                    <div class="p-1">
                                        <span class="label-one">Direción: </span>
                                        <asp:Label ID="txtUAddress" runat="server" Text="" CssClass="label-two"></asp:Label>
                                    </div>
                                    <div class="p-1">
                                        <span class="label-one">Código postal: </span>
                                        <asp:Label ID="txtUpostal" runat="server" Text="" CssClass="label-two"></asp:Label>
                                    </div>


                               </div>
        </div>
          <div class="row">
                                                         
                                      
                   
                    </div>

    </div>
      <asp:Label ID="error" runat="server" Text=""></asp:Label>
                            <asp:Label ID="result" runat="server" Text=""></asp:Label>

</asp:Content>
