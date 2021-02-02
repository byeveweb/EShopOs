using EShopOS.Application;
using EShopOS.Core;
using EShopOS.DAL;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EShopOS.Web.Account
{
    public partial class AddContacDateUser : System.Web.UI.Page
    {


        ApplicationDbContext context = null;
        OrderManager orderManager = null;



        protected void Page_Load(object sender, EventArgs e)

        {
            context = new ApplicationDbContext();
            orderManager = new OrderManager(context);

            var manager = Context.GetOwinContext().GetUserManager<ApplicationUserManager>();
            var user = manager.FindById(User.Identity.GetUserId());

            txtUserId.Text = user.Id.ToString();
            txtEmail.Text = user.Email;
            txtCity.Text = user.City;
            txtCodPostal.Text = user.PostalCode.ToString();
            txtPostalAddress.Text = user.PostalAddress;
            txtName.Text = user.NameAndSurname;
 


        }

        protected void Comprar_Click(object sender, EventArgs e)

        {
            Order order = new Order
            {
                CreatedDateOrder = DateTime.Now,
                OrderStatus = OrderStatus.Open,
                User_Id = HttpContext.Current.User.Identity.GetUserId()
            };

           

            orderManager.Add(order);
            orderManager.Context.SaveChanges();
            Response.Redirect("home");
            //try
            //{
            //    var manager1 = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext()));
            //    var currentUser = manager1.FindById(User.Identity.GetUserId());

            //    currentUser.NameAndSurname = txtName.Text;
            //    manager1.UpdateAsync(currentUser);
            //    Response.Redirect("home");
            //}
            //catch(Exception ex)
            //{
            //         error.Text =   ex.ToString();

            //}

        }
    }
}

