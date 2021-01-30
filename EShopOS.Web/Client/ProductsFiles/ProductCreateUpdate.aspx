<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductCreateUpdate.aspx.cs" Inherits="EShopOS.Web.Client.ProductCreateUpdate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Editar producto</h2>
    <hr />
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
    <asp:HiddenField ID="txtId" runat="server" />
    <div class="form-group">
        <asp:Label ID="NameProduct" runat="server" Text="Nombre del Producto" AssociatedControlID="txtNameProduct"></asp:Label>
        <asp:TextBox ID="txtNameProduct" runat="server" Text=""></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Campo obligatorio" ControlToValidate="txtNameProduct" Text="Campo obligatorio"></asp:RequiredFieldValidator>
    </div>
    <div class="form-group">
        <asp:Label ID="DescriptionProduct" runat="server" Text="Descripción de producto" AssociatedControlID="txtDescriptionProduct"></asp:Label>
        <asp:TextBox ID="txtDescriptionProduct" runat="server" TextMode="MultiLine" Rows="10"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Campo obligatorio" ControlToValidate="txtDescriptionProduct" Text="Campo obligatorio"></asp:RequiredFieldValidator>
    </div>
    <div class="form-group">
        <asp:Label ID="PriceProduct" runat="server" Text="Precio Unitario de producto" AssociatedControlID="txtPriceProduct"></asp:Label>
        <asp:TextBox ID="txtPriceProduct" runat="server" ></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Campo obligatorio" ControlToValidate="txtPriceProduct" Text="Campo obligatorio"></asp:RequiredFieldValidator>
    </div>
     <div class="form-group">
        <asp:Label ID="StockProduct" runat="server" Text="Stock de producto" AssociatedControlID="txtStockProduct"></asp:Label>
        <asp:TextBox ID="txtStockProduct" runat="server" ></asp:TextBox>
    </div>
    <div class="form-group">
        <asp:Label ID="StatusProduct" runat="server" Text="Disponibilidad de producto" AssociatedControlID="selStatusProduct"></asp:Label>
             <asp:DropDownList ID="selStatusProduct" runat="server"></asp:DropDownList>
    </div>
      <div class="form-group">
          <asp:Button ID="btnSubmit" runat="server" Text="Editar Producto" OnClick="btnSubmit_Click"/>
    </div>

</asp:Content>
