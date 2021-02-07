﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductDetailAndUpdate.aspx.cs" Inherits="EShopOS.Web.Client.ProductCreateUpdate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:HiddenField ID="txtId" runat="server" />

    <div class="secction">
         <asp:Label ID="result" runat="server"></asp:Label>

            <div class="title2">
                <h2 runat="server" id="nuevoPd" Visible="true">Crear Nuevo producto</h2>
                <h2 runat="server" id="editarPd" Visible="false">Editar producto Nuevo producto</h2>
            </div>

            <div class="p-15">
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" CssClass="alert alert-primary" />
                
                <div class="row">
                  

                </div>
                <hr />

                <div class="row">
                    <h5>Id de producto: </h5>
                    <asp:Label ID="txtIdProduct" runat="server" Text=""></asp:Label>

                </div>
                <hr />

                <div class="row">

                        <div class="col-md-6">
                                <div class="form-group">
                                    <asp:Label ID="NameProduct" runat="server" Text="Nombre del Producto" AssociatedControlID="txtNameProduct"></asp:Label>
                                    <asp:TextBox ID="txtNameProduct" runat="server" Text="" CssClass="form-control text-box input-one-line"></asp:TextBox>
                                    <asp:RequiredFieldValidator CssClass="form-text text-muted" ID="RequiredFieldValidator1" runat="server" ErrorMessage="Campo obligatorio" ControlToValidate="txtNameProduct" Text="Campo obligatorio"></asp:RequiredFieldValidator>
                                </div>
                                <div class="form-group">
                                    <asp:Label ID="PriceProduct" runat="server" Text="Precio Unitario de producto" AssociatedControlID="txtPriceProduct"></asp:Label>
                                    <asp:TextBox CssClass="form-control text-box input-one-line" ID="txtPriceProduct" runat="server" ></asp:TextBox>
                                    <asp:RequiredFieldValidator CssClass="form-text text-muted" ID="RequiredFieldValidator3" runat="server" ErrorMessage="Campo obligatorio" ControlToValidate="txtPriceProduct" Text="Campo obligatorio"></asp:RequiredFieldValidator>
                                </div>
                            <div class="form-group">
                                    <label for="exampleFormControlFile1">Subir imagen</label>
                                <input type="file" class="form-control-file" id="exampleFormControlFile1">
                                </div>
                        </div>

                        <div class="col-md-6">

                                 <div class="form-group">
                                    <asp:Label ID="DescriptionProduct" runat="server" Text="Descripción de producto" AssociatedControlID="txtDescriptionProduct"></asp:Label>
                                    <asp:TextBox ID="txtDescriptionProduct" runat="server" TextMode="MultiLine" Rows="10" CssClass="form-control text-box"></asp:TextBox>
                                    <asp:RequiredFieldValidator CssClass="form-text text-muted" ID="RequiredFieldValidator2" runat="server" ErrorMessage="Campo obligatorio" ControlToValidate="txtDescriptionProduct" Text="Campo obligatorio"></asp:RequiredFieldValidator>
                                </div>
                        </div>
                 </div>

                <hr />
                <div class="row">
                         <div class="col-md-6">
                             <div class="form-group">
                                <asp:Label ID="StockProduct" runat="server" Text="Stock de producto" AssociatedControlID="txtStockProduct"></asp:Label>
                                <asp:TextBox ID="txtStockProduct" runat="server" CssClass="form-control text-box input-one-line"></asp:TextBox>
                            </div>
                         </div>
                     
                        <div class="col-md-6">
                
                            <div class="form-group">
                                <asp:Label ID="StatusProduct" runat="server" Text="Disponibilidad de producto" AssociatedControlID="selStatusProduct"></asp:Label>
                                <asp:DropDownList ID="selStatusProduct" runat="server" CssClass="form-control text-box input-one-line"></asp:DropDownList>
                            </div>
                        </div>
                           
                  </div>
                <hr />

               <div class="row link-section p-15">

                  <div class="form-group">
                      <asp:Button ID="btnSubmit" runat="server" Text="Crear nuevo producto" OnClick="btnSubmit_Click" CssClass="btn btn-pink-dark"/>
                    </div>
                </div>
        </div>




</div>
</asp:Content>