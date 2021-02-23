using EShopOS.Application;
using EShopOS.Core;
using EShopOS.DAL;
using Microsoft.AspNet.Identity;
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
        ApplicationUserManager user = null;


        protected void Page_Load(object sender, EventArgs e)
        {

            // Traemos el contexto
            context = new ApplicationDbContext();



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

                
                         

            }
            catch
            {

                //TODO: error, no encontrado
                result.Text = "No se ha encontrado la incidencia indicada";
                result.CssClass = "has-error";


            }
        }

        //protected void closeOrder_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        od.OrderStatus = OrderStatus.Close;

        //        orderManager.Context.SaveChanges();
        //        Response.Redirect("OrderList.aspx");
        //    }
        //    catch (Exception ex)
        //    {
        //        result.Text = "Se ha producido un error, al cerrar la orden";
        //        result.CssClass = "has-error";
        //    }
        //}

        //protected void processOrder_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        od.OrderStatus = OrderStatus.Process;

        //        orderManager.Context.SaveChanges();
        //        Response.Redirect("OrderList.aspx");
        //    }
        //    catch (Exception ex)
        //    {
        //        result.Text = "Se ha producido un error, al cerrar la orden";
        //        result.CssClass = "has-error";
        //    }
        //}

        ////Eliminamos la orden
        //protected void deleteOrder_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        orderManager.Remove(od);
        //        var orderDetailsCarts = orderDetailManager
        //            .GetAll()
        //            .Where(u => u.Order_Id == od.Id);

        //        foreach (var ord in orderDetailsCarts)
        //        {

        //            orderDetailManager.Remove(ord);
        //        }

        //        orderManager.Context.SaveChanges();
        //        Response.Redirect("OrderList.aspx");
        //    }
        //    catch (Exception ex)
        //    {
        //        result.Text = "Se ha producido un error, al cerrar la orden";
        //        result.CssClass = "has-error";
        //    }
        //}

        protected void backOrder_Click(object sender, EventArgs e)
        {
            Response.Redirect("OrderList.aspx");
        }
    }
}