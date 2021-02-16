using EShopOS.Application;
using EShopOS.Core;
using EShopOS.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EShopOS.Web.Client.OrdersFiles
{
    public partial class OrderDetail1 : System.Web.UI.Page
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

                od = orderManager.GetById(new object[] { idtext });




                txtOid.Text = od.User_Id.ToString();
                txtODateCreation.Text = od.CreatedDateOrder.ToString();
                selStatusOrder.SelectedValue = od.OrderStatus.ToString();
                selStatusOrder.DataSource = Enum.GetValues(typeof(OrderStatus));
                var pS = selStatusOrder.SelectedValue;
                selStatusOrder.DataBind();
                selStatusOrder.SelectedValue = pS;

               

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


            }

            catch (Exception ex)
            {
                result.Text = "Se ha producido un error, si este persiste contacte con el administrador";
                result.CssClass = "has-error";
            }


        }
    }
}