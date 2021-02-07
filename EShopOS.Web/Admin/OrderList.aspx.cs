using EShopOS.Application;
using EShopOS.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EShopOS.Web.Admin
{
    public partial class OrderList : System.Web.UI.Page
    {
        ApplicationDbContext context = null;
        OrderManager orderManager = null;
        protected void Page_Load(object sender, EventArgs e)
        {

            context = new ApplicationDbContext();
            orderManager = new OrderManager(context);

            var idtext = Request.QueryString["Id"];

            var orders = orderManager
                            .GetAll()
                            .OrderBy(i => i.Id);
            string formatlink = "<a href='OrderUpdate.aspx?Id={0}'>{1}</a>";


            foreach (var or in orders)
            {
                var row = new TableRow();
                row.Cells.Add(new TableCell { Text = string.Format(formatlink, or.Id, or.Id.ToString()) });
                row.Cells.Add(new TableCell { Text = string.Format(formatlink, or.Id, or.CreatedDateOrder.ToString()) });
                row.Cells.Add(new TableCell { Text = string.Format(or.OrderStatus.ToString()) });
                row.Cells.Add(new TableCell { Text = string.Format(or.User_Id.ToString()) });
                row.Cells.Add(new TableCell { Text = string.Format(formatlink, or.Id, "Editar") });
                row.Cells.Add(new TableCell { Text = string.Format("X") });
                tbody.Controls.Add(row);
            }

        }
    }
}