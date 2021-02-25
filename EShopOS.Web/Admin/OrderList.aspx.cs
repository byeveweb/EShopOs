using EShopOS.Application;
using EShopOS.Core;
using EShopOS.DAL;
using Microsoft.Ajax.Utilities;
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

namespace EShopOS.Web.Admin
{
    public partial class OrderList : System.Web.UI.Page
    {
        ApplicationDbContext context = null;
        OrderManager orderManager = null;
        OrderDetailManager orderDetailManager = null;


        protected void Page_Load(object sender, EventArgs e)
        {

            context = new ApplicationDbContext();
            orderManager = new OrderManager(context);
            orderDetailManager = new OrderDetailManager(context);



            try
            {

                var idtext = Request.QueryString["Id"];

             
                
                
                var orders = orderManager
                    .GetAll()
                    .Include(u => u.User)
                    .Include(o => o.OrderDetails)
                    .OrderByDescending(m => m.CreatedDateOrder);
                                
                string formatlink = "<a href='OrderUpdate.aspx?Id={0}'>{1}</a>";
                
               

                foreach (var or in orders)
                {
                    
                    var row = new TableRow();
                    row.Cells.Add(new TableCell { Text = string.Format(formatlink, or.Id, or.Id.ToString()) });
                    row.Cells.Add(new TableCell { Text = string.Format(formatlink, or.Id, or.CreatedDateOrder.ToString()) });
                    row.Cells.Add(new TableCell { Text = string.Format(or.OrderStatus.ToString()) });
                    row.Cells.Add(new TableCell { Text = string.Format(or.User.Email.ToString()) });
                    row.Cells.Add(new TableCell { Text = string.Format(formatlink, or.Id, "Ver/Editar") });
                    tbody.Controls.Add(row);
                   
                }

                

            }
            catch
            {

                //TODO: error, no encontrado
                result.Text = "No se ha encontrado la incidencia indicada";
                result.CssClass = "has-error";


            }
        }

        }
    }
