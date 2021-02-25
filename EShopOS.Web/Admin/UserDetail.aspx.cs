using EShopOS.Application;
using EShopOS.Core;
using EShopOS.DAL;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EShopOS.Web.Admin
{
    public partial class UserDetail : System.Web.UI.Page
    {
        ApplicationDbContext context = null;
        OrderManager orderManager = null;


        protected void Page_Load(object sender, EventArgs e)
        {

            // Traemos el contexto
            context = new ApplicationDbContext();
            orderManager = new OrderManager(context);



            try
            {
                var manager = Context.GetOwinContext().GetUserManager<ApplicationUserManager>();
                var user = manager.FindById(User.Identity.GetUserId());

                txtUId.Text = user.Id;
                txtUCity.Text= user.City;
                txtUEmail.Text = user.Email;
                txtUName.Text= user.NameAndSurname;
                txtUPhone.Text = user.PhoneNumber.ToString();
                txtUAddress.Text = user.PostalAddress;
                txtUpostal.Text = user.PostalCode.ToString();

                var orders = orderManager
                             .GetAll().Where(u => u.User_Id == user.Id);

                string formatlink = "<a href='OrderUpdate.aspx?Id={0}'>{1}</a>";


                foreach (var or in orders)
                {
                    var row = new TableRow();
                    row.Cells.Add(new TableCell { Text = string.Format(formatlink, or.Id, or.Id.ToString()) });
                    row.Cells.Add(new TableCell { Text = string.Format(formatlink, or.Id, or.CreatedDateOrder.ToString()) });
                    row.Cells.Add(new TableCell { Text = string.Format(or.OrderStatus.ToString()) });
                    row.Cells.Add(new TableCell { Text = string.Format(formatlink, or.Id, "Ver/Editar") });
                    tbody.Controls.Add(row);
                }


            }
            catch
            {

                //TODO: error, no encontrado
                result.Text = "No se ha encontrado la orden indicada";
                result.CssClass = "has-error";


            }
        }

        //Eliminamos la orden
        protected void deleteUser_Click(object sender, EventArgs e)
        {
            try
            {
              //  Traemos los datos de la orden
            var idtext = Request.QueryString["Id"];
                var managerUser = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
                var currentUser = managerUser.FindById(idtext);


                managerUser.Delete(currentUser);
                Response.Redirect("UserList.aspx");
            }
            catch (Exception ex)
            {
                result.Text = "Se ha producido un error, al eliminar el usuario";
                result.CssClass = "has-error";
            }
        }

        protected void backUser_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserList.aspx");
        }
    }
}