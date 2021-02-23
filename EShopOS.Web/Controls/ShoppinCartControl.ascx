<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ShoppinCartControl.ascx.cs" Inherits="EShopOS.Web.Controls.ShoppinCartControl" %>

<div  class="row">
    <asp:Label ID="txtIdCart" runat="server" Text="" CssClass="card-title" Visible="False"></asp:Label>
    <asp:Label ID="txtUserId" runat="server" Text="" CssClass="card-title" Visible="False"></asp:Label>
    <div class="lineacarrito title-select">

         <div class="row no-mrg " style="width: 100%">
             <div class="col-md-12 no-pdd" >
                <div class="texto-carrito margin-r-1">
                    <asp:Label ID="txtProductName" runat="server" Text="" CssClass="texto-carrito"></asp:Label>
                </div>
             </div>
             <div class="row no-mrg "  style="width: 100%">
                 <div class="col-md-4 no-pdd">
                    <div class="texto-carrito margin-r-1">
                        <asp:Label ID="txtProductPrice" runat="server" Text="" CssClass="texto-carrito"></asp:Label>€
                    </div>
                </div>

                 <div class="col-md-4 no-pdd">
                    <div class="texto-carrito margin-r-1 text-right">
                        <asp:Label ID="txtQuantity" runat="server" Text="" CssClass="card-title"></asp:Label> und.
                    </div>
                </div>
                <div class="col-md-4 no-pdd">
                    <div class="texto-carrito margin-r-1 text-right">
                        <asp:Label ID="txtTotal" runat="server" Text="" CssClass="card-title"></asp:Label> €.
                    </div>
                    
                </div>
                    <%--<asp:Button ID="X" runat="server" Text="Button" OnClick="Button1_Click" />--%>
                    <%--<asp:LinkButton ID="LinkButton1" runat="server" OnClientClick="Button1_Click" PostBackUrl="~/Client/ProductsFiles/ProductCat.aspx">LinkButton</asp:LinkButton>--%>
       
              </div>

        </div>

         
    </div>
</div>
 