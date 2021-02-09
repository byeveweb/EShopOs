<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ProductControl.ascx.cs" Inherits="EShopOS.Web.Controls.ProductControl" %>
<div class="col-md-12 no-pdd product-detail margin-b-1">
    <div class="bg-white">
        <div class="row no-mrg" >

            <div class="col-md-8 no-pdd " >
                        <div class="pd-title font-fantastic font-size-25 margin-15">
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
        <div class="row no-mrg " >
            <div class="col-md-3 no-pdd" >
                <div class="image-product">
                    <asp:Image ID="txtImageUrl" runat="server" ImageUrl="~/Content/Images/1.jpg" />
                </div>
            </div>

            <div class="col-md-9">
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
                                <label for="QuantityProduct" class="margin-r-1">Add</label>
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
                            <asp:Button ID="AddCart" runat="server" Text="+" OnClientClick="return false;" CssClass="btn-pink-light btn add addCart" Visible="false"/>
                       </div>
                    </div>
                </div>
                    <div class="pd-title">
                        <asp:Label ID="txtDescription" runat="server" Text="" CssClass="description-product"></asp:Label>
                    </div>
                    
        </div>
            </div>
     </div>
</div>







