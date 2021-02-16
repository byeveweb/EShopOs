<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddContactDateUser.aspx.cs" Inherits="EShopOS.Web.Account.AddContacDateUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <div class="secction">
            <div class="bg-pink-dark pr-title">
                <h1 class="font-fantastic">Dirección</h1>
             </div>


            <div class="p-15">

                        <div class="row ">


                            <div class="col-md-8 p-15">

                                
                                     <asp:ValidationSummary runat="server" CssClass="text-danger" />
                                        <p class="text-danger">
                                     <asp:Literal runat="server" ID="ErrorMessage" />
                                        </p>

                                   <div class="form-group">
                                            <asp:Label runat="server" AssociatedControlID="txtName" CssClass="label-3">Nombre y Apellidos</asp:Label>
                                        
                                            <asp:TextBox runat="server" ID="txtName" CssClass="form-control label-4" />
                                            <asp:RequiredFieldValidator runat="server" ControlToValidate="txtName"
                                                CssClass="text-danger" ErrorMessage="El campo txtName es obligatorio." />
                                        </div>
                                   

                                    <div class="form-group">
                                        <asp:Label runat="server" AssociatedControlID="txtPostalAddress" CssClass="label-3">Dirección</asp:Label>
                                        
                                            <asp:TextBox runat="server" ID="txtPostalAddress" CssClass="form-control label-4" />
                                            <asp:RequiredFieldValidator runat="server" ControlToValidate="txtPostalAddress"
                                                CssClass="text-danger" ErrorMessage="El campo txtPostalAddress es obligatorio." />
                                    


                                    </div>
                                    <div class="form-group">
                                        <asp:Label runat="server" AssociatedControlID="txtCity" CssClass="label-3">Ciudad</asp:Label>
                                        
                                            <asp:TextBox runat="server" ID="txtCity" CssClass="form-control label-4" />
                                            <asp:RequiredFieldValidator runat="server" ControlToValidate="txtCity"
                                                CssClass="text-danger" ErrorMessage="El campo txtCity es obligatorio." />
                                       
                                    </div>
                                    <div class="form-group">
                                    <asp:Label runat="server" AssociatedControlID="txtCodPostal" CssClass="label-3">Código Postal</asp:Label>
                             
                                        <asp:TextBox runat="server" ID="txtCodPostal" CssClass="form-control label-4" />
                                        <asp:RequiredFieldValidator runat="server" ControlToValidate="txtCodPostal"
                                            CssClass="text-danger" ErrorMessage="El campo txtCodPostal es obligatorio." />
                          
                                </div>

                                <div class="form-group">
                                    <asp:Label runat="server" AssociatedControlID="txtPhoneNumber" CssClass="label-3">Número de teléfono</asp:Label>
                                 
                                        <asp:TextBox runat="server" ID="txtPhoneNumber" CssClass="form-control label-4" TextMode="Phone"/>
                                        <asp:RequiredFieldValidator runat="server" ControlToValidate="txtPhoneNumber"
                                            CssClass="text-danger" ErrorMessage="El campo PhoneNumber es obligatorio." />
                                    
                                </div>


                        </div>
                                                         <div class="col-md-4 p-15 bg-pink-light">

                                    <div class="title2 ">
                                           <h5>Datos de Usuario</h5>
                                    </div>

                                    <div class="p-1">
                                        <span class="label-one">Usuario: </span>
                                        <asp:Label ID="txtUserId" runat="server" Text="" Visible="False" CssClass="price"></asp:Label>
                                        <asp:Label ID="txtEmail" runat="server" Text="" CssClass="datosUsuario"></asp:Label>
                                    </div>
                                                                                             <div class="form-group">
                                    <div class="margin-15">
                                        <asp:Button runat="server" 
                                            Text="Continuar" CssClass="btn btn-pink-dark" OnClick="Comprar_Click" />
                                    </div>
                                </div>
                            </div>
                            <asp:Label ID="error" runat="server" Text=""></asp:Label>
                            <asp:Label ID="result" runat="server" Text=""></asp:Label>
                                                                            </div>
                     </div>
                </div>
     
</asp:Content>
