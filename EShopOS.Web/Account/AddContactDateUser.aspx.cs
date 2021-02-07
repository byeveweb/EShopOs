﻿using EShopOS.Application;
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
                    //txtPhoneNumber.Text = user.PhoneNumber.ToString();
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
            Order order = new Order
            {
                CreatedDateOrder = DateTime.Now,
                OrderStatus = OrderStatus.Open,
                User_Id = userId,
                OrderDetails = new List<OrderDetail>(),
            };

            var shoppingCarts = shoppingCartManager.GetAll().Include(u => u.Product).Where(u => u.User_Id == userId);
            foreach (var sh in shoppingCarts)
            {
                order.OrderDetails.Add(new OrderDetail { Price = sh.Product.Price, Product_Id = sh.Product_Id, Quantity = sh.Quantity });
            }


            var manager1 = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            var currentUser = manager1.FindById(User.Identity.GetUserId()); 
            currentUser.PostalAddress = txtPostalAddress.Text; 
            manager1.Update(currentUser);

            orderManager.Add(order);
            orderManager.Context.SaveChanges();
            Response.Redirect("~/Client/OrdersFiles/OrderConfirm?Id=" + order.Id);
          

        }
    }
}
