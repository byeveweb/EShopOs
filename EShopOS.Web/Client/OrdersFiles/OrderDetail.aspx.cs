using EShopOS.Application;
using EShopOS.Core;
using EShopOS.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EShopOS.Web.Client.OrdersFiles
{
    public partial class OrderDetail : System.Web.UI.Page
    {

        ApplicationDbContext context = null;
        OrderManager orderManager = null;
        ProductManager productManager = null;
        Order order = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            //Traemos el contexto de los datos de producto capa de datos
            context = new ApplicationDbContext();
            orderManager = new OrderManager(context);
            productManager = new ProductManager(context);

            //Traemos el id del usuario
            var idtext = Request.QueryString["Id"];
            int id = 0;

            //
            order = orderManager.GetById(new object[] { id });

            //txtOrderId.Text = order.Id.ToString();
            //txtDateTime.Text = order.CreatedDateOrder.ToString("dd/MM/yyyy");



            // var order = orderManager.GetAll();
            //var content = (ContentPlaceHolder)Master.FindControl("MainContent");



            //foreach (var product in products)
            //{
            //    var control = (ProductControl)Page.LoadControl("~/Controls/ProductControl.ascx");
            //    control.Product = product;
            //    content.Controls.Add(control);
            //}

            //var carts = shoppingCartManager.GetAll();
            //var contentCart = (ContentPlaceHolder)Master.FindControl("MainContent");



            //foreach (var cart in carts)
            //{
            //    var control = (ShoppinCartControl)Page.LoadControl("~/Controls/ShoppinCartControl.ascx");
            //    control.ShoppingCart = cart;
            //    content.Controls.Add(control);
            //}

        }
    }
}