using EShopOS.Application;
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
        ApplicationDbContext context = null;
        ShoppingCartManager shoppingCartManager = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            context = new ApplicationDbContext();
            shoppingCartManager = new ShoppingCartManager(context);


            txtIdCart.Text = ShoppingCart.Id.ToString();
            //txtUserId.Text = ShoppingCart.User_Id.ToString();
            txtProductName.Text = ShoppingCart.Product.NameProduct.ToString();
            txtProductPrice.Text = ShoppingCart.Product.Price.ToString();
            txtQuantity.Text = ShoppingCart.Quantity.ToString();
            txtTotal.Text = ShoppingCart.Total.ToString();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var idpro = 1;
            var sh = shoppingCartManager.GetAll().Where(u => u.Product_Id == idpro);

            foreach (var s in sh)
            {
                shoppingCartManager.Remove(s);
            }

            shoppingCartManager.Context.SaveChanges();
            Response.Redirect("ProductCat.aspx");
        }
    }
}