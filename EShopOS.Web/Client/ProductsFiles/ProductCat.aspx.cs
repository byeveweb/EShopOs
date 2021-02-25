using EShopOS.Application;
using EShopOS.Core;
using EShopOS.DAL;
using EShopOS.Web.Controls;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Globalization;
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


            //Pintamos el producto
            var products = productManager.GetAll();
            var content = (ContentPlaceHolder)Master.FindControl("Producto");


            foreach (var product in products)
            {
                var control = (ProductControl)Page.LoadControl("~/Controls/ProductControl.ascx");
                control.Product = product;
                content.Controls.Add(control);
            }


            ////Pintamos el carrito
            string userId = HttpContext.Current.User.Identity.GetUserId();
            var carts = shoppingCartManager.GetAll().Where(u => u.User_Id == userId).Include(u => u.User);
            var contentCart = (ContentPlaceHolder)Master.FindControl("CarritoShop");
            decimal su = 0;

            foreach (var cart in carts)
            {
                var controlC = (ShoppinCartControl)Page.LoadControl("~/Controls/ShoppinCartControl.ascx");
                controlC.ShoppingCart = cart;
                contentCart.Controls.Add(controlC);
                su += cart.Total;
<<<<<<< HEAD

            }


=======
                
            }
>>>>>>> 4bc47852fc31575efc45bb816f6af3eb8e4325c9
            //Mostramos el total y formateamos
            string specifier = "F";
            CultureInfo culture = CultureInfo.CreateSpecificCulture("fr-FR");
            txtTotalismo.Text = su.ToString(specifier, culture);
<<<<<<< HEAD

=======
     
>>>>>>> 4bc47852fc31575efc45bb816f6af3eb8e4325c9
            //Determinamos si está autenticado
            bool isAuth = System.Web.HttpContext.Current.User.Identity.IsAuthenticated;

            if (!isAuth)
            {
                Buy.Enabled= false;
                alert.Visible = true;
                total.Visible = false;
            }

            else
            {

                Buy.Enabled = true;
                alert.Visible = false;
                total.Visible = true;
            }

        }

        protected void Buy_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Account/AddContactDateUser.aspx");
        }


    }
}