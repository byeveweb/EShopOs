using EShopOS.Application;
using EShopOS.Core;
using EShopOS.DAL;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
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
    public partial class OrderCreate : System.Web.UI.Page
    {
        ApplicationDbContext context = null;
        OrderManager orderManager = null;
        OrderDetailManager orderDetailManager = null;
        Order od = null;


        protected void Page_Load(object sender, EventArgs e)
        {
            // Traemos el contexto
            context = new ApplicationDbContext();
            orderManager = new OrderManager(context);
            orderDetailManager = new OrderDetailManager(context);


            try
            {

                //Traemos los datos de la orden
                var idtext = Int32.Parse(Request.QueryString["Id"]);

                //Mostramos los datos de la orden
                od = orderManager
                    .GetById(new object[] { idtext });

                txtOid.Text = od.Id.ToString();
                txtODateCreation.Text = od.CreatedDateOrder.ToString();
                statusOrder.Text = od.OrderStatus.ToString();



                //Mostramos el número total de artículos
                var cont = orderDetailManager
                    .GetAll()
                    .Where(o => o.Order_Id == od.Id)
                    .Count();

                txtArti.Text = cont.ToString();



                //Traemos los datos de usuario
                var userId = od.User_Id;
                var odus = orderManager
                    .GetAll()
                    .Where(u => u.User_Id == userId)
                    .Include(sc => sc.User);

                //Pintamos datos para Usuario
                foreach (var odu in odus)
                {
                    txtUId.Text = odu.User.Id;
                    txtUEmail.Text = odu.User.Email;
                    txtUName.Text = odu.User.NameAndSurname;
                    txtUPhone.Text = odu.User.PhoneNumber;
                }


                //Traemos los datos de detalle de la orden
                decimal su = 0;
                var orderId = od.Id;
                var ordts = orderDetailManager
                    .GetAll()
                    .Where(u => u.Order_Id == orderId)
                    .Include(or => or.Order)
                    .Include(pr => pr.Product);
                   


                //Pintamos datos para Usuario
                foreach (var ordt in ordts)
                {

                    var row = new TableRow();
                    row.Cells.Add(new TableCell { Text = string.Format(ordt.Product_Id.ToString()) });
                    row.Cells.Add(new TableCell { Text = string.Format(ordt.Product.NameProduct.ToString()) });
                    row.Cells.Add(new TableCell { Text = string.Format(ordt.Price.ToString()) });
                    row.Cells.Add(new TableCell { Text = string.Format(ordt.Quantity.ToString()) });
                    row.Cells.Add(new TableCell { Text = string.Format(ordt.Total.ToString()) });
                    tbody.Controls.Add(row);
                    su += ordt.Total;
                }

                //Sumamos el total de las celdas y mostramos como decimales
                string specifier = "F";
                CultureInfo culture = CultureInfo.CreateSpecificCulture("fr-FR");
                txtTotalismo.Text = su.ToString(specifier, culture);


            }

            catch (Exception ex)
            {
                result.Text = "Se ha producido un error, si este persiste contacte con el administrador";
                result.CssClass = "has-error";
            }
        }


        protected void closeOrder_Click(object sender, EventArgs e)
        {
            try
            {
                od.OrderStatus = OrderStatus.Close;

                orderManager.Context.SaveChanges();
                Response.Redirect("OrderList.aspx");
            }
            catch (Exception ex)
            {
                result.Text = "Se ha producido un error, al cerrar la orden";
                result.CssClass = "has-error";
            }
        }

        protected void processOrder_Click(object sender, EventArgs e)
        {
            try
            {
                od.OrderStatus = OrderStatus.Process;

                orderManager.Context.SaveChanges();
                Response.Redirect("OrderList.aspx");
            }
            catch (Exception ex)
            {
                result.Text = "Se ha producido un error, al cerrar la orden";
                result.CssClass = "has-error";
            }
        }

        //Eliminamos la orden
        protected void deleteOrder_Click(object sender, EventArgs e)
        {
            try
            {
                orderManager.Remove(od);
                var orderDetailsCarts = orderDetailManager
                    .GetAll()
                    .Where(u => u.Order_Id == od.Id);

                foreach (var ord in orderDetailsCarts)
                {

                    orderDetailManager.Remove(ord);
                }

                orderManager.Context.SaveChanges();
                Response.Redirect("OrderList.aspx");
            }
            catch (Exception ex)
            {
                result.Text = "Se ha producido un error, al cerrar la orden";
                result.CssClass = "has-error";
            }
        }

        protected void backOrder_Click(object sender, EventArgs e)
        {
            Response.Redirect("OrderList.aspx");
        }
    }
}