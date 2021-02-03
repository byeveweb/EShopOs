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

namespace EShopOS.Web.Account
{
    public partial class AddContacDateUser : System.Web.UI.Page
    {


        ApplicationDbContext context = null;
        OrderManager orderManager = null;
        ShoppingCartManager shoppingCartManager = null;



        protected void Page_Load(object sender, EventArgs e)

        {
            context = new ApplicationDbContext();
            orderManager = new OrderManager(context);
            shoppingCartManager = new ShoppingCartManager(context);

            var manager = Context.GetOwinContext().GetUserManager<ApplicationUserManager>();
            var user = manager.FindById(User.Identity.GetUserId());

            if (!Page.IsPostBack)
            {
                txtUserId.Text = user.Id.ToString();
                txtEmail.Text = user.Email;
                txtCity.Text = user.City;
                txtCodPostal.Text = user.PostalCode.ToString();
                txtPostalAddress.Text = user.PostalAddress;
                txtName.Text = user.NameAndSurname;
            }

        }

        protected void Comprar_Click(object sender, EventArgs e)

        {
            string userId = HttpContext.Current.User.Identity.GetUserId();
            Order order = new Order
            {
                CreatedDateOrder = DateTime.Now,
                OrderStatus = OrderStatus.Open,
                User_Id = userId,
                OrderDetails = new List<OrderDetail>()
            };

            var shoppingCarts = shoppingCartManager.GetAll().Include(u=> u.Product).Where(u => u.User_Id == userId);
            foreach(var sh in shoppingCarts)
            {
                order.OrderDetails.Add(new OrderDetail { Price = sh.Product.Price, Product_Id = sh.Product_Id, Quantity = sh.Quantity });
            }

            foreach (var sh in shoppingCarts)
            {
                shoppingCartManager.Remove(sh);
            }


            var manager1 = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            var currentUser = manager1.FindById(User.Identity.GetUserId()); 
            currentUser.PostalAddress = txtPostalAddress.Text; 
            manager1.Update(currentUser);
            // Response.Redirect("home");

            orderManager.Add(order);
            orderManager.Context.SaveChanges();
            Response.Redirect("~/Client/OrderFiles/OrderDetail.aspx");
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

