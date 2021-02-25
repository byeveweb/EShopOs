using EShopOS.Application;
using EShopOS.Core;
using EShopOS.DAL;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EShopOS.Web.Client.OrdersFiles
{
    public partial class OrderDetail : System.Web.UI.Page
    {

        ApplicationDbContext context = null;
        OrderDetailManager orderDetailManager = null;
        OrderManager orderManager = null;
        ProductManager productManager = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            // Traemos el contexto
            context = new ApplicationDbContext();
            orderManager = new OrderManager(context);
            orderDetailManager = new OrderDetailManager(context);
<<<<<<< HEAD
            productManager = new ProductManager(context);

            try { 

                //Almacenamos en variables UserId y traemos los datos de usuario perteneciente al User
                string userId = HttpContext.Current.User.Identity.GetUserId();
                var orders = orderManager.GetAll().Where(u => u.User_Id == userId).Include(sc => sc.User);
=======


            //Almacenamos en variables UserId y traemos los datos de usuario perteneciente al User
            string userId = HttpContext.Current.User.Identity.GetUserId();
            var orders = orderManager.GetAll().Where(u => u.User_Id == userId).Include(sc => sc.User);

            //Pintamos datos para Usuario
            foreach (var cart in orders)
            {
                txtUsername.Text = cart.User.NameAndSurname;
                txtEmail.Text = cart.User.Email;
                txtPostalCode.Text = cart.User.PostalCode.ToString();
                txtPostalAddress.Text = cart.User.PostalAddress;
                txtCity.Text = cart.User.City;
                txtPhoneNumber.Text = cart.User.PhoneNumber.ToString();
            }
>>>>>>> 4bc47852fc31575efc45bb816f6af3eb8e4325c9

                //Pintamos datos para Usuario
                foreach (var cart in orders)
                {
                    txtUsername.Text = cart.User.NameAndSurname;
                    txtEmail.Text = cart.User.Email;
                    txtPostalCode.Text = cart.User.PostalCode.ToString();
                    txtPostalAddress.Text = cart.User.PostalAddress;
                    txtCity.Text = cart.User.City;
                    txtPhoneNumber.Text = cart.User.PhoneNumber.ToString();
                }

<<<<<<< HEAD
                //Datos de la orden
                var idtext = Int32.Parse(Request.QueryString["Id"]);
=======
            var od = orderManager.GetById(new object[] { idtext });
            txtOrderId.Text = od.Id.ToString();
            txtCreateOrder.Text = od.CreatedDateOrder.ToString("dd/MM/yyyy");
            txtOrderStatus.Text = od.OrderStatus.ToString();
>>>>>>> 4bc47852fc31575efc45bb816f6af3eb8e4325c9

                var od = orderManager.GetById(new object[] { idtext });
                txtOrderId.Text = od.Id.ToString();
                txtCreateOrder.Text = od.CreatedDateOrder.ToString("dd/MM/yyyy");
                txtOrderStatus.Text = od.OrderStatus.ToString();


<<<<<<< HEAD

                ////datos de producto
                var orderId = od.Id;
                decimal su = 0;
                var ordts = orderDetailManager.GetAll().Where(u => u.Order_Id == orderId).Include(or => or.Order).Include(pr => pr.Product);
                var prodCarts = productManager.GetAll();

                string formatlink = "<a href='ProductDetail.aspx?Id={0}'>{1}</a>";
                string linkremove = "<a href='#' class='elim'>X</a>";



                foreach (var ord in ordts)
                {
                    var row = new TableRow();
                    row.Cells.Add(new TableCell { Text = string.Format(ord.Product.Id.ToString()) });
                    row.Cells.Add(new TableCell { Text = string.Format(formatlink, ord.Product.Id, ord.Product.NameProduct.ToString()) });
                    row.Cells.Add(new TableCell { Text = string.Format(ord.Product.Price.ToString()) });
                    row.Cells.Add(new TableCell { Text = string.Format(ord.Quantity.ToString()) });
                    row.Cells.Add(new TableCell { Text = string.Format(ord.Total.ToString()) });
                    row.Cells.Add(new TableCell { Text = string.Format(formatlink, ord.Product.Id, "Ver") });
                    row.Cells.Add(new TableCell { Text = string.Format(linkremove, ord.Product.Id, "X") });

                    tbody.Controls.Add(row);

                    su += ord.Total;
                }
            
                //Sumamos el total de las celdas y mostramos como decimales
                string specifier = "F";
                CultureInfo culture = CultureInfo.CreateSpecificCulture("fr-FR");
                txtTotalismo.Text = su.ToString(specifier, culture);

            }
            catch
            {

                //TODO: error, no encontrado
                result.Text = "El carrito está vacio";
                result.CssClass = "has-error";
                buy_confirm.Enabled = false;


            }
=======
            ////datos de producto
            var orderId = od.Id;
            decimal su = 0;
            var ordts = orderDetailManager.GetAll().Where(u => u.Order_Id == orderId).Include(or => or.Order).Include(pr => pr.Product);
            string formatlink = "<a href='ProductDtl.aspx?Id={0}'>{1}</a>";

            foreach (var ord in ordts)
            {
                var row = new TableRow();
                row.Cells.Add(new TableCell { Text = string.Format(formatlink, ord.Id, ord.Product.Id.ToString()) });
                row.Cells.Add(new TableCell { Text = string.Format(formatlink, ord.Id, ord.Product.NameProduct.ToString()) });
                row.Cells.Add(new TableCell { Text = string.Format(formatlink, ord.Id, ord.Product.Price.ToString()) });
                row.Cells.Add(new TableCell { Text = string.Format(formatlink, ord.Id, ord.Quantity.ToString()) });
                row.Cells.Add(new TableCell { Text = string.Format(formatlink, ord.Id, ord.Total.ToString()) });
                row.Cells.Add(new TableCell { Text = string.Format(formatlink, ord.Id, "Ver") });
                row.Cells.Add(new TableCell { Text = string.Format(formatlink, ord.Id, "Eliminar") });
                tbody.Controls.Add(row);

                su += ord.Total;
            }
            
            //Sumamos el total de las celdas y mostramos como decimales
            string specifier = "F";
            CultureInfo culture = CultureInfo.CreateSpecificCulture("fr-FR");
            txtTotalismo.Text = su.ToString(specifier, culture);
>>>>>>> 4bc47852fc31575efc45bb816f6af3eb8e4325c9
        }

        protected void buy_confirm_Click(object sender, EventArgs e)
        {

            string userId = HttpContext.Current.User.Identity.GetUserId();
            var orderId = Int32.Parse(Request.QueryString["Id"]);

            Order order = new Order
            {
                CreatedDateOrder = DateTime.Parse(txtCreateOrder.Text),
                User_Id = userId,
                OrderStatus = (OrderStatus)1,
            };

            orderManager.Context.SaveChanges();
            Response.Redirect("~/Client/OrdersFiles/OrderDetail?Id=" + orderId);

        }



        //Eliminar todos los productos de la cesta
        protected void del2_Click(object sender, EventArgs e)
        {
            //Traemos el id del usuario
            var orderId = Int32.Parse(Request.QueryString["Id"]);


            //Traemos toda la orden de detalle 
            var ordts = orderDetailManager.GetAll().Where(y => y.Order_Id == orderId);

            foreach (var od in ordts)
            {
                orderDetailManager.Remove(od);
            }
            orderDetailManager.Context.SaveChanges();
            Response.Redirect("OrderConfirm.aspx");
        }
    }
}