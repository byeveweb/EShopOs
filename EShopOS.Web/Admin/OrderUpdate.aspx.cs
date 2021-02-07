using EShopOS.Application;
using EShopOS.Core;
using EShopOS.DAL;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EShopOS.Web.Client.OrdersFiles
{
    public partial class OrderCreate : System.Web.UI.Page
    {
        ApplicationDbContext context = null;
        ProductManager productManager = null;
        ShoppingCartManager shoppingCartManager = null;
        OrderManager orderManager = null;
        OrderDetailManager orderDetailManager = null;
        Order order = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            // Traemos el contexto
            context = new ApplicationDbContext();
            shoppingCartManager = new ShoppingCartManager(context);
            productManager = new ProductManager(context);
            orderManager = new OrderManager(context);
            orderDetailManager = new OrderDetailManager(context);



            //Traemos los datos de la orden
            var idtext = Int32.Parse(Request.QueryString["Id"]);

            var od = orderManager.GetById(new object[] { idtext });
            txtOid.Text = od.User_Id.ToString();
            txtODateCreation.Text = od.CreatedDateOrder.ToString();
            selStatusOrder.SelectedValue = od.OrderStatus.ToString();



            //Traemos los datos de usuario
            var userId = od.User_Id;
            var odus = orderManager.GetAll().Where(u => u.User_Id == userId).Include(sc => sc.User);

            //Pintamos datos para Usuario
            foreach (var odu in odus)
            {
                txtUId.Text = odu.User.Id;
                txtUEmail.Text = odu.User.Email;
                txtUName.Text = odu.User.NameAndSurname;
                txtUPhone.Text = odu.User.PhoneNumber;
            }


            //Traemos los datos de detalle de la orden
            var orderId = od.Id;
            var ordts = orderDetailManager.GetAll().Where(u => u.Order_Id == orderId).Include(or => or.Order).Include(pr => pr.Product);
            
            string formatlink = "<a href='ProductDetailAndUpdate.aspx?Id={0}'>{1}</a>";


            //Pintamos datos para Usuario
            foreach (var ordt in ordts)
            {

                var row = new TableRow();
                row.Cells.Add(new TableCell { Text = string.Format(formatlink, ordt.Id, ordt.Id.ToString()) });
                row.Cells.Add(new TableCell { Text = string.Format(formatlink, ordt.Id, ordt.Order_Id.ToString()) });
                row.Cells.Add(new TableCell { Text = string.Format(ordt.Product_Id.ToString()) });
                row.Cells.Add(new TableCell { Text = string.Format(ordt.Price.ToString()) });
                row.Cells.Add(new TableCell { Text = string.Format(ordt.Quantity.ToString()) });
                row.Cells.Add(new TableCell { Text = string.Format(ordt.Total.ToString()) });
                row.Cells.Add(new TableCell { Text = string.Format(formatlink, ordt.Id, "Ver") });
                tbody.Controls.Add(row);
            }





            //Almacenamos en variables UserId y traemos los datos de usuario perteneciente al User
            //string userId = HttpContext.Current.User.Identity.GetUserId();
            //var carts = orderCartManager.GetAll().Where(u => u.User_Id == userId).Include(sc => sc.User);

            ////Pintamos datos para Usuario
            //foreach (var cart in carts)
            //{
            //    txtOid.Text = cart.User.NameAndSurname;
            //    txtEmail.Text = cart.User.Email;
            //    txtPostalCode.Text = cart.User.PostalCode.ToString();
            //    txtPostalCode.Text = cart.User.PostalCode.ToString();
            //    txtPostalAddress.Text = cart.User.PostalAddress;
            //    txtCity.Text = cart.User.City;
            //    // txtPhoneNumber.Text = cart.User.PhoneNumber.ToString();
            //}

            //Datos de la orden




            //datos de producto
            //var products = shoppingCartManager.GetAll().Where(u => u.User_Id == userId).Include(sc => sc.User).Include(pr => pr.Product);
            //string formatlink = "<a href='ProductDtl.aspx?Id={0}'>{1}</a>";

            //foreach (var pdr in products)
            //{
            //    var row = new TableRow();
            //    row.Cells.Add(new TableCell { Text = string.Format(formatlink, pdr.Id, pdr.Product.NameProduct.ToString()) });
            //    row.Cells.Add(new TableCell { Text = string.Format(formatlink, pdr.Id, pdr.Product.Description.ToString()) });
            //    row.Cells.Add(new TableCell { Text = string.Format(formatlink, pdr.Id, pdr.Product.Price.ToString()) });
            //    row.Cells.Add(new TableCell { Text = string.Format(formatlink, pdr.Id, pdr.Product.Stock.ToString()) });
            //    row.Cells.Add(new TableCell { Text = string.Format(formatlink, pdr.Id, pdr.Product.ProductStatus.ToString()) });
            //    tbody.Controls.Add(row);


            //}





            //Cargar la lista de usuarios
            //Dictionary<string, string> userlist = new Dictionary<string, string>();
            //UserManager<ApplicationUser> userManager =
            //    new UserManager<ApplicationUser>(
            //        new UserStore<ApplicationUser>(context));
            //userList.DataSource = userManager.Users.ToList();
            //userList.DataValueField = "Id";
            //userList.DataTextField = "Username";

            //var userSelected = userList.SelectedValue;
            //userList.DataBind();
            //userList.SelectedValue = userSelected;

            //Cargar la lista de Products
            //selProduct.DataSource = productManager.GetAll().ToList();
            //selProduct.DataValueField = "Id";
            //selProduct.DataTextField = "NameProduct";

            //var productSelected = selProduct.SelectedValue;
            //selProduct.DataBind();
            //selProduct.SelectedValue = productSelected;
            //priceProduct.Text = productSelected;

            //var products = productManager.GetAll();

            //foreach(var p in products)
            //{
            //    priceProduct.Text = product.Price.ToString();
            //}


            //txtfechaOrder.Text = DateTime.Now.ToString();
            //priceProduct.Text = "2";
            //cantidad.Text = "2";
            //total.Text = "2";



            //var precio = product.Price;
            //var cantidad = 2;
            //var totales = cantidad * precio;


            //selStatusOrder.DataSource = Enum.GetValues(typeof(OrderStatus));
            //selStatusOrder.DataBind();
            //txtfechaOrder.Text = DateTime.Now.ToString();



        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            //Order order = new Order
            //{
            //    CreatedDateOrder = DateTime.Now,
            //    OrderStatus = OrderStatus.Open,
            //    User_Id = "",// HttpContext.Current.User.Identity.GetUserId()
            //    OrderDetails = new List<OrderDetail>()
            //};
            //order.OrderDetails.Add(new OrderDetail
            //{
            //    Price = Int32.Parse(priceProduct.Text),
            //    Quantity = Int32.Parse(cantidad.Text),
            //    Total = Int32.Parse(total.Text),
            //    Product_Id = 1
            //});
            //order.OrderDetails.Add(new OrderDetail
            //{
            //    Price = Int32.Parse(priceProduct.Text),
            //    Quantity = Int32.Parse(cantidad.Text),
            //    Total = Int32.Parse(total.Text),
            //    Product_Id = 2
            //});

            //orderManager.Add(order);
            //orderManager.Context.SaveChanges();
            //Response.Redirect("home");

        }

      
    }
}