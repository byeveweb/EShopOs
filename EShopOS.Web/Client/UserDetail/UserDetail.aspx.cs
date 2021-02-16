using EShopOS.Application;
using EShopOS.DAL;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EShopOS.Web.Client.UserDetail
{
    public partial class UserDetail : System.Web.UI.Page 
    { 

        ApplicationDbContext context = null;
        OrderDetailManager orderDetailManager = null;
        OrderManager orderManager = null;
    
        protected void Page_Load(object sender, EventArgs e)
        {

            // Traemos el contexto
            context = new ApplicationDbContext();
            orderManager = new OrderManager(context);
            orderDetailManager = new OrderDetailManager(context);
            
            
            try { 
                var manager = Context.GetOwinContext().GetUserManager<ApplicationUserManager>();
                var user = manager.FindById(User.Identity.GetUserId());

                txtUsername.Text = user.Email;
                txtEmail.Text = user.Email;
                txtCity.Text = user.City;
                txtPostalAddress.Text = user.PostalAddress;
                txtPostalCode.Text = user.PostalCode.ToString();
                if (user.PhoneNumber != null)
                {
                    txtPhoneNumber.Text = user.PhoneNumber.ToString();
                }
                else { txtPhoneNumber.Text = "sin telefono"; }


                var orders = orderManager
                               .GetAll().Where(u => u.User_Id == user.Id);

                string formatlink = "<a href='~/Client/OrdersFile/OrderDetail.aspx?Id={0}'>{1}</a>";


                foreach (var or in orders)
                {
                    var row = new TableRow();
                    row.Cells.Add(new TableCell { Text = string.Format(formatlink, or.Id, or.Id.ToString()) });
                    row.Cells.Add(new TableCell { Text = string.Format(formatlink, or.Id, or.CreatedDateOrder.ToString()) });
                    row.Cells.Add(new TableCell { Text = string.Format(or.OrderStatus.ToString()) });
                    row.Cells.Add(new TableCell { Text = string.Format(formatlink, or.Id, "Ver") });
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
