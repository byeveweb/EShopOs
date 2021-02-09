using EShopOS.Application;
using EShopOS.Core;
using EShopOS.DAL;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EShopOS.Web.Client.OrdersFiles
{
    public partial class OrderDetail : System.Web.UI.Page
    {

        ApplicationDbContext context = null;
        ProductManager productManager = null;
        ShoppingCartManager shoppingCartManager = null;
        OrderManager orderManager = null;


        protected void Page_Load(object sender, EventArgs e)
        {
            // Traemos el contexto
            context = new ApplicationDbContext();
            shoppingCartManager = new ShoppingCartManager(context);
            productManager = new ProductManager(context);
            orderManager = new OrderManager(context);

            //Almacenamos en variables UserId y traemos los datos de usuario perteneciente al User
            string userId = HttpContext.Current.User.Identity.GetUserId();
            var carts = shoppingCartManager.GetAll().Where(u => u.User_Id == userId).Include(sc => sc.User);

            //Pintamos datos para Usuario
            foreach (var cart in carts)
            {
                txtUsername.Text = cart.User.NameAndSurname;
                txtEmail.Text = cart.User.Email;
                txtPostalCode.Text = cart.User.PostalCode.ToString();
                txtPostalAddress.Text = cart.User.PostalAddress;
                txtCity.Text = cart.User.City;
                txtPhoneNumber.Text = cart.User.PhoneNumber.ToString();
            }

            //Datos de la orden
            var idtext = Int32.Parse(Request.QueryString["Id"]);

            var od = orderManager.GetById(new object[] { idtext });
            txtOrderId.Text = od.Id.ToString();
            //txtUserId.Text = od.User_Id.ToString();
            txtCreateOrder.Text = od.CreatedDateOrder.ToString("dd/MM/yyyy");
            txtOrderStatus.Text = od.OrderStatus.ToString();



            //datos de producto

            var products = shoppingCartManager.GetAll().Where(u => u.User_Id == userId).Include(sc => sc.User).Include(pr => pr.Product);
            string formatlink = "<a href='ProductDtl.aspx?Id={0}'>{1}</a>";

            foreach (var pdr in products)
            {
                var row = new TableRow();
                row.Cells.Add(new TableCell { Text = string.Format(formatlink, pdr.Id, pdr.Product.Id.ToString()) });
                row.Cells.Add(new TableCell { Text = string.Format(formatlink, pdr.Id, pdr.Product.NameProduct.ToString()) });
                row.Cells.Add(new TableCell { Text = string.Format(formatlink, pdr.Id, pdr.Product.Price.ToString()) });
                row.Cells.Add(new TableCell { Text = string.Format(formatlink, pdr.Id, pdr.Quantity.ToString()) });
                row.Cells.Add(new TableCell { Text = string.Format(formatlink, pdr.Id, pdr.Quantity.ToString()) });

                //  row.Cells.Add(new TableCell { Text = string.Format(formatlink, pdr.Id, pdr.Product.ProductStatus.ToString()) });
                tbody.Controls.Add(row);


            }


            //Me servirá para solicitar pedidos
            //var pd = productManager.GetAll();
            //pdList.DataSource = shoppingCartManager.GetAll().Where(u => u.User_Id == userId).Include(sc => sc.User).Include(pr => pr.Product).ToList();
            //pdList.DataBind();




        }

        protected void buy_confirm_Click(object sender, EventArgs e)
        {

            string userId = HttpContext.Current.User.Identity.GetUserId();
            Order order = new Order
            {
                CreatedDateOrder = DateTime.Parse(txtCreateOrder.Text),
                User_Id = userId,
                OrderStatus = (OrderStatus)1,
            };

            orderManager.Context.SaveChanges();
            Response.Redirect("OrderDetail.aspx");

        }
    }
}