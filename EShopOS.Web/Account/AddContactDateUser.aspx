<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddContactDateUser.aspx.cs" Inherits="EShopOS.Web.Account.AddContacDateUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="form-horizontal">
        <h4>Agregar direción de entrega</h4>
        <hr />
        <asp:ValidationSummary runat="server" CssClass="text-danger" />
        <p class="text-danger">
            <asp:Literal runat="server" ID="ErrorMessage" />
        </p>
        <div class="form-group">
            <h3>-Uusario</h3>
        <asp:Label ID="txtUserId" runat="server" Text=""></asp:Label>
        <asp:Label ID="txtEmail" runat="server" Text="" ></asp:Label>
            </div>

        
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="txtName" CssClass="col-md-2 control-label">Nombre y Apellidos</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="txtName" CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtName"
                    CssClass="text-danger" ErrorMessage="El campo txtName es obligatorio." />
            </div>
        </div>
                <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="txtPostalAddress" CssClass="col-md-2 control-label">Dirección</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="txtPostalAddress" CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtPostalAddress"
                    CssClass="text-danger" ErrorMessage="El campo txtPostalAddress es obligatorio." />
            </div>
        </div>
                        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="txtCity" CssClass="col-md-2 control-label">Ciudad</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="txtCity" CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtCity"
                    CssClass="text-danger" ErrorMessage="El campo txtCity es obligatorio." />
            </div>
        </div>
                                <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="txtCodPostal" CssClass="col-md-2 control-label">Código Postal</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="txtCodPostal" CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtCodPostal"
                    CssClass="text-danger" ErrorMessage="El campo txtCodPostal es obligatorio." />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="PhoneNumber" CssClass="col-md-2 control-label">Número de teléfono</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="PhoneNumber" CssClass="form-control" TextMode="Phone" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="PhoneNumber"
                    CssClass="text-danger" ErrorMessage="El campo PhoneNumber es obligatorio." />
            </div>
        </div>

        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <asp:Button runat="server" 
                    Text="Continuar con la compra" CssClass="btn btn-default" OnClick="Comprar_Click" />
            </div>
        </div>
    </div>
        <asp:Label ID="error" runat="server" Text=""></asp:Label>

</asp:Content>
