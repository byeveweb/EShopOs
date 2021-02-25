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

            try {

                if (!Page.IsPostBack)
                {
                    txtUserId.Text = user.Id.ToString();
                    txtEmail.Text = user.Email;
                    txtCity.Text = user.City;
                    txtCodPostal.Text = user.PostalCode.ToString();
                    txtPostalAddress.Text = user.PostalAddress;
                    txtName.Text = user.NameAndSurname;
<<<<<<< HEAD
                    
                    if (user.PhoneNumber != null ) {
                        txtPhoneNumber.Text = user.PhoneNumber.ToString();

=======
                    txtPhoneNumber.Text = user.PhoneNumber.ToString();
                    if (user.PhoneNumber != null ) { 
                        
>>>>>>> 4bc47852fc31575efc45bb816f6af3eb8e4325c9
                    } else { txtPhoneNumber.Text = "sin telefono"; }

                   
                }

            } catch
            {
                //TODO: error, no encontrado
                result.Text = "No se ha encontrado la incidencia indicada";
                result.CssClass = "has-error";


            }

        }

        protected void Comprar_Click(object sender, EventArgs e)

        {

            string userId = HttpContext.Current.User.Identity.GetUserId();

            //Vamos a crear la orden
            Order order = new Order
            {
                CreatedDateOrder = DateTime.Now,
                OrderStatus = OrderStatus.Open,
                User_Id = userId,
                OrderDetails = new List<OrderDetail>(),
            };

            //Vas a crear la tabla de Orders Details
<<<<<<< HEAD
            var shoppingCarts = shoppingCartManager
                .GetAll()
                .Include(u => u.Product)
                .Where(u => u.User_Id == userId);
=======
            var shoppingCarts = shoppingCartManager.GetAll().Include(u => u.Product).Where(u => u.User_Id == userId);
>>>>>>> 4bc47852fc31575efc45bb816f6af3eb8e4325c9

            foreach (var sh in shoppingCarts)
            {
                order.OrderDetails.Add(new OrderDetail { Price = sh.Product.Price, Product_Id = sh.Product_Id, Quantity = sh.Quantity, Total = (int)sh.Total });
                shoppingCartManager.Remove(sh); 
            }


            //Actualizamoslos datos de Usuario
            var manager1 = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
<<<<<<< HEAD
            var currentUser = manager1
                .FindById(User.Identity
                .GetUserId()); 

=======
            var currentUser = manager1.FindById(User.Identity.GetUserId()); 
>>>>>>> 4bc47852fc31575efc45bb816f6af3eb8e4325c9
            currentUser.PostalAddress = txtPostalAddress.Text;
            currentUser.City = txtCity.Text;
            currentUser.Email = txtEmail.Text;
            currentUser.NameAndSurname = txtName.Text;
            currentUser.PostalCode = Int32.Parse(txtCodPostal.Text);
            currentUser.PhoneNumber = txtPhoneNumber.Text;
            manager1.Update(currentUser);

            //Eliminamos cesta los datos
            shoppingCartManager.Context.SaveChanges();

            //añadimos Datos
            orderManager.Add(order);
            orderManager.Context.SaveChanges();
           
            Response.Redirect("~/Client/OrdersFiles/OrderConfirm?Id=" + order.Id);

        }
    }
}

