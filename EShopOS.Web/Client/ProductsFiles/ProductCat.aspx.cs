using EShopOS.Application;
using EShopOS.Core;
using EShopOS.DAL;
using EShopOS.Web.Controls;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EShopOS.Web.Client.ProductsFiles
{
    public partial class ProductDtl : System.Web.UI.Page
    {
        ApplicationDbContext context = null;
        ProductManager productManager = null;
        ShoppingCartManager shoppingCartManager = null;

        protected void Page_Load(object sender, EventArgs e)
        {

            //Traemos el contexto de los datos de producto capa de datos
            context = new ApplicationDbContext();
            productManager = new ProductManager(context);
            shoppingCartManager = new ShoppingCartManager(context);

            var products = productManager.GetAll();
            var content = (ContentPlaceHolder)Master.FindControl("Producto");

            foreach (var product in products)
            {
                var control = (ProductControl)Page.LoadControl("~/Controls/ProductControl.ascx");
                control.Product = product;
                content.Controls.Add(control);
            }

            string userId = HttpContext.Current.User.Identity.GetUserId();
            var carts = shoppingCartManager.GetAll().Where(u=> u.User_Id == userId).Include(u=> u.User);
            var contentCart = (ContentPlaceHolder)Master.FindControl("Carrito");


            foreach (var cart in carts)
            {
                var controlC = (ShoppinCartControl)Page.LoadControl("~/Controls/ShoppinCartControl.ascx");
                controlC.ShoppingCart = cart;
                contentCart.Controls.Add(controlC);
            }




            bool isAuth = System.Web.HttpContext.Current.User.Identity.IsAuthenticated;

            if (!isAuth)
            {
                Buy.Enabled= false;
                alert.Visible = true;
            }

            else
            {

                Buy.Enabled = true;
                alert.Visible = false;
            }

        }

        private void LoadProduct(Product product)
        {
            //txtId.Value = product.Id.ToString();
            //txtNameProduct.Text = product.NameProduct;
            
        }

        protected void Buy_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Account/AddContactDateUser.aspx");
        }
    }
}