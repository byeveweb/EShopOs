using EShopOS.Application;
using EShopOS.Core;
using EShopOS.DAL;
using EShopOS.Web.Controls;
using System;
using System.Collections.Generic;
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
            var content = (ContentPlaceHolder)Master.FindControl("MainContent");



            foreach (var product in products)
            {
                var control = (ProductControl)Page.LoadControl("~/Controls/ProductControl.ascx");
                control.Product = product;
                content.Controls.Add(control);
            }

            var carts = shoppingCartManager.GetAll();
            var contentCart = (ContentPlaceHolder)Master.FindControl("MainContent");



            foreach (var cart in carts)
            {
                var control = (ShoppinCartControl)Page.LoadControl("~/Controls/ShoppinCartControl.ascx");
                control.ShoppingCart = cart;
                content.Controls.Add(control);
            }



            //int id = 0;
            //var idt = Request.QueryString["id"];
            ////Traemos el
            //if (idt != null)
            //{

            //    if (int.TryParse(Request.QueryString["id"], out id))
            //    {
            //        Product product = productManager.GetById(id);
            //        LoadProduct(product);

            //    }
            //}

        }

        private void LoadProduct(Product product)
        {
            //txtId.Value = product.Id.ToString();
            //txtNameProduct.Text = product.NameProduct;
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Account/AddContactDateUser.aspx");
        }
    }
}