using EShopOS.Core;
using EShopOS.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EShopOS.Web.Controls
{
    public partial class ShoppinCartControl : System.Web.UI.UserControl
    {
        public ShoppingCart ShoppingCart { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            txtIdCart.Text = ShoppingCart.Id.ToString();
            txtUserId.Text = ShoppingCart.User_Id.ToString();
            txtProductName.Text = ShoppingCart.Product.NameProduct.ToString();
            txtProductPrice.Text = ShoppingCart.Product.Price.ToString();
            txtQuantity.Text = ShoppingCart.Quantity.ToString();
            txtTotal.Text = ShoppingCart.Total.ToString();

        }
    }
}