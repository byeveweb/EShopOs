using EShopOS.Application;
using EShopOS.Core;
using EShopOS.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;

namespace EShopOS.Web.Controls
{
    public partial class ProductControl : System.Web.UI.UserControl

    {
        /// <summary>
        /// Traemos los contexto 
        /// </summary>
        ApplicationDbContext context = null;
        ShoppingCartManager shoppingCartManager = null;

        /// <summary>
        /// Traemos el producto
        /// </summary>
        public Product Product { get; set; }


        protected void Page_Load(object sender, EventArgs e)
        {
            
            
            context = new ApplicationDbContext();
            shoppingCartManager = new ShoppingCartManager(context);

            
                // Pintamos los datos
                txtProductId.Text = Product.Id.ToString();
                txtNameProduct.Text = Product.NameProduct.ToString();
                txtDescription.Text = Product.Description.ToString();
                txtPrice.Text = Product.Price.ToString();
                txtStock.Text = Product.Stock.ToString();
                txtProductStatus.Text = Product.ProductStatus.ToString();
                txtImageUrl.ImageUrl = Product.ImageUrl;

            

            //Determinamos si está o no logueado
            bool isAuth = System.Web.HttpContext.Current.User.Identity.IsAuthenticated;
  
            if (!isAuth) {
                AddCart.Visible= false;  }

            else {

                AddCart.Visible = true; ; ;
            }



        }

        protected void AddCart_Click(object sender, EventArgs e)
        {
            
            ShoppingCart shoppingCart = new ShoppingCart
            {
 
                Product_Id = Int32.Parse(txtProductId.Text),
                User_Id = HttpContext.Current.User.Identity.GetUserId(),
                Quantity = Int32.Parse(QuantityProduct.SelectedValue),
        };


            shoppingCartManager.Add(shoppingCart);
            shoppingCartManager.Context.SaveChanges();
        }
    }
}