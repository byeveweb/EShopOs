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
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EShopOS.Web.Client.OrdersFiles
{
    public partial class OrderDetail1 : System.Web.UI.Page
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
            productManager = new ProductManager(context);

            try
            {

                //Almacenamos en variables UserId y traemos los datos de usuario perteneciente al User
                string userId = HttpContext.Current.User.Identity.GetUserId();
                var orders = orderManager.GetAll().Where(u => u.User_Id == userId).Include(sc => sc.User);

                //Datos de la orden
                var idtext = Int32.Parse(Request.QueryString["Id"]);
                var od = orderManager.GetById(new object[] { idtext });

                txtOrderId.Text = od.Id.ToString();
                txtCreateOrder.Text = od.CreatedDateOrder.ToString("dd/MM/yyyy");
                txtOrderStatus.Text = od.OrderStatus.ToString();


                ////datos de producto
                var orderId = od.Id;
                decimal su = 0;
                var ordts = orderDetailManager.GetAll().Where(u => u.Order_Id == orderId).Include(or => or.Order).Include(pr => pr.Product);
                var prodCarts = productManager.GetAll();
                string formatlink = "<a href='ProductDtl.aspx?Id={0}'>{1}</a>";




                foreach (var ord in ordts)
                {
                    var row = new TableRow();
                    row.Cells.Add(new TableCell { Text = string.Format(formatlink, ord.Id, ord.Product.Id.ToString()) });
                    row.Cells.Add(new TableCell { Text = string.Format(formatlink, ord.Id, ord.Product.NameProduct.ToString()) });
                    row.Cells.Add(new TableCell { Text = string.Format(formatlink, ord.Id, ord.Product.Price.ToString()) });
                    row.Cells.Add(new TableCell { Text = string.Format(formatlink, ord.Id, ord.Quantity.ToString()) });
                    row.Cells.Add(new TableCell { Text = string.Format(formatlink, ord.Id, ord.Total.ToString()) });
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


            }


        }
    }
}