using EShopOS.Application;
using EShopOS.Core;
using EShopOS.DAL;
using EShopOS.Web.Helpers;
using Microsoft.AspNet.Identity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Script.Services;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.Serialization;

namespace EShopOS.Web.Controls
{
    /// <summary>
    /// Descripción breve de ShopingCart
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    [ScriptService]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    //[System.Web.Script.Services.ScriptService]
    public class ShopingCart : System.Web.Services.WebService
    {
        ApplicationDbContext context = null;

        [WebMethod]
        [ScriptMethod()]
        public string AddCart(int productId, int quantity)
        {
            context = new ApplicationDbContext();
            ShoppingCartManager scm = new ShoppingCartManager(context);
            ProductManager productManager = new ProductManager(context);

            var pr = productManager.GetById(productId);
            var user = HttpContext.Current.User.Identity.GetUserId();
           

            var sc = scm.GetAll().Where(e => e.User_Id == user && e.Product_Id == productId).SingleOrDefault();
            decimal price = pr.Price;
            decimal total = price * quantity;


            if (sc != null)
            {
                sc.Quantity = sc.Quantity + quantity;
                sc.Total = sc.Quantity * price;
                total = sc.Total;
            }
            else
            {
                ShoppingCart shoppingCart = new ShoppingCart
                {

                    Product_Id = productId,
                    User_Id = user,
                    Quantity = quantity,
                    Total = total,

                };

                scm.Add(shoppingCart);
            }
            scm.Context.SaveChanges();

            //Pintamos el carrito
            StringBuilder sb = new StringBuilder();
            string userId = HttpContext.Current.User.Identity.GetUserId();
            var carts = scm.GetAll().Where(u => u.User_Id == userId).Include(u => u.User).Include(u => u.Product);

            foreach (var cart in carts)
            {
                var cu = UserControls.RenderUserControl(
                    "~/Controls/ShoppinCartControl.ascx",
                    new Dictionary<string, object> { { "ShoppingCart", cart } });
                sb.Append(cu);
            }


            return sb.ToString();
        }
    }
}
