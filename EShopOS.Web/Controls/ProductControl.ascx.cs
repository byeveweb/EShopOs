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
        ApplicationDbContext context = null;
        ShoppingCartManager shoppingCartManager = null;

        public Product Product { get; set; }


        protected void Page_Load(object sender, EventArgs e)
        {
            context = new ApplicationDbContext();
            shoppingCartManager = new ShoppingCartManager(context);



            ProductId.Text = Product.Id.ToString();
            txtNameProduct.Text = Product.NameProduct.ToString();
            txtDescription.Text = Product.Description.ToString();
            txtPrice.Text = Product.Price.ToString();
            txtStock.Text = Product.Stock.ToString();
            txtProductStatus.Text = Product.ProductStatus.ToString();

           ;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            ShoppingCart shoppingCart = new ShoppingCart
            {
 
                Product_Id = Int32.Parse(ProductId.Text),
                User_Id = HttpContext.Current.User.Identity.GetUserId(),
                Quantity =1
            };


            shoppingCartManager.Add(shoppingCart);
            shoppingCartManager.Context.SaveChanges();
            //Response.Redirect("home");
        }
    }
}