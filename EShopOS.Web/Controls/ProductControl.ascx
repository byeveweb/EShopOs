<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ProductControl.ascx.cs" Inherits="EShopOS.Web.Controls.ProductControl" %>
<div class="col-md-12 no-pdd product-detail margin-b-1">
    <div class="bg-white">
        <div class="row no-mrg " >
            <div class="col-md-4 no-pdd" >
                <div class="image-product">
                    <asp:Image ID="txtImageUrl" runat="server" ImageUrl="~/Content/Images/1.jpg" />
                </div>
            </div>

            <div class="col-md-8">
                <div class="row no-mrg df-jf-start" >
                        <div class="col-md-8 no-pdd " >
                            <div class="pd-title tlt-product margin-15">
                            <asp:Label ID="txtNameProduct" runat="server" Text="" CssClass="card-title"></asp:Label>
                            </div>
                        </div>
                        <div class="col-md-4 no-pdd" >
                            <div class="pd-title margin-15 text-right">
                                <asp:Label ID="txtProductId" runat="server" Text="" CssClass="cl-pr-id"></asp:Label> | 
                                 <asp:Label ID="txtProductStatus" runat="server" Text="" CssClass="cl-pr-id"></asp:Label> | 
                                <asp:Label ID="txtStock" runat="server" Text="" CssClass="cl-pr-id"></asp:Label>
              
                            </div>
                        </div>
                  </div>
                <div class="row no-mrg df-jf-start" >
                        <div class="col-md-4">
                            <div class="pd-title">
                                <h5>P.V.P:</h5>
                                <asp:Label ID="txtPrice" runat="server" Text="" CssClass="price"></asp:Label>€
                            </div>
                        </div>
                        <div class="col-md-4">
                            <form>
                               <div class="form-group title-select pd-title">
                                    <asp:DropDownList ID="QuantityProduct" runat="server" CssClass="form-control quantity">
                                        <asp:ListItem Value="1">1</asp:ListItem>
                                        <asp:ListItem Value="2">2</asp:ListItem>
                                        <asp:ListItem Value="3">3</asp:ListItem>
                                     </asp:DropDownList>
                              </div>
                            </form>
                            </div>
                        <div class="col-md-4">
                           <div class="text-right">
<<<<<<< HEAD
                                <asp:Button ID="AddCart" runat="server" Text="+" OnClientClick="return false;" CssClass="btn-pink-light btn addCart" Visible="true"/>

=======
                                <asp:Button ID="AddCart" runat="server" Text="+" OnClientClick="return false;" CssClass="btn-pink-light btn add addCart" Visible="false"/>
>>>>>>> 4bc47852fc31575efc45bb816f6af3eb8e4325c9
                           </div>
                        </div>
                   </div>
                <div class="row no-mrg df-jf-start" >
                            <div class=" pd-title margin-15">
                                <asp:Label ID="txtDescription" runat="server" Text="" CssClass="description-product"></asp:Label>
                            </div>
                        </div>
<<<<<<< HEAD
                        <%--<asp:Button ID="verPro" runat="server" Text="Ver Detalle producto" OnClick="verPro_Click" CssClass="btn-pink-light btn"/>--%>
=======
                <div class="row no-mrg df-jf-start margin-15" >
                    <asp:HyperLink ID="pdetail" runat="server" CssClass="link" NavigateUrl="~/Client/ProductFile/ProductDtl.aspx">Ver detalle >></asp:HyperLink>
                </div>
>>>>>>> 4bc47852fc31575efc45bb816f6af3eb8e4325c9
            </div>
         </div>

        </div>
</div>






