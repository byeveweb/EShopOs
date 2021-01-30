using EShopOS.Application;
using EShopOS.Core;
using EShopOS.DAL;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EShopOS.Web.Client.OrdersFiles
{
    public partial class OrderCreate : System.Web.UI.Page
    {
        ApplicationDbContext context = null;
        OrderManager orderManager = null;
        ProductManager productManager = null;
        Product product = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            //Traemos el contexto de los datos de producto capa de datos
            context = new ApplicationDbContext();
            orderManager = new OrderManager(context);
            productManager = new ProductManager(context);
            

            //Cargar la lista de usuarios
            //Dictionary<string, string> userlist = new Dictionary<string, string>();
            UserManager<ApplicationUser> userManager =
                new UserManager<ApplicationUser>(
                    new UserStore<ApplicationUser>(context));
            userList.DataSource = userManager.Users.ToList();
            userList.DataValueField = "Id";
            userList.DataTextField = "Username";

            var userSelected = userList.SelectedValue;
            userList.DataBind();
            userList.SelectedValue = userSelected;

            //Cargar la lista de Products
            selProduct.DataSource = productManager.GetAll().ToList();
            selProduct.DataValueField = "Id";
            selProduct.DataTextField = "NameProduct";

            var productSelected = selProduct.SelectedValue;
            selProduct.DataBind();
            selProduct.SelectedValue = productSelected;
            priceProduct.Text = productSelected;

            //var products = productManager.GetAll();

            //foreach(var p in products)
            //{
            //    priceProduct.Text = product.Price.ToString();
            //}
            

            txtfechaOrder.Text = DateTime.Now.ToString();
            priceProduct.Text = "2";
            cantidad.Text = "2";
            total.Text = "2";



            //var precio = product.Price;
            //var cantidad = 2;
            //var totales = cantidad * precio;


            //selStatusOrder.DataSource = Enum.GetValues(typeof(OrderStatus));
            //selStatusOrder.DataBind();
            //txtfechaOrder.Text = DateTime.Now.ToString();



        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Order order = new Order
            {
                CreatedDateOrder = DateTime.Now,
                OrderStatus = OrderStatus.Open,
                User_Id = "",// HttpContext.Current.User.Identity.GetUserId()
                OrderDetails = new List<OrderDetail>()
            };
            order.OrderDetails.Add(new OrderDetail
            {
                Price = Int32.Parse(priceProduct.Text),
                Quantity = Int32.Parse(cantidad.Text),
                Total = Int32.Parse(total.Text),
                Product_Id = 1
            });
            order.OrderDetails.Add(new OrderDetail
            {
                Price = Int32.Parse(priceProduct.Text),
                Quantity = Int32.Parse(cantidad.Text),
                Total = Int32.Parse(total.Text),
                Product_Id = 2
            });

            orderManager.Add(order);
            orderManager.Context.SaveChanges();
            Response.Redirect("home");

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            Product product = new Product()
            {

            };

        }
    }
}