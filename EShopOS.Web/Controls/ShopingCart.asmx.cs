﻿using EShopOS.Application;
using EShopOS.Core;
using EShopOS.DAL;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;
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



            if (sc != null) { 
                sc.Quantity = sc.Quantity + quantity;
                sc.Total = sc.Quantity * price;
            }

            else {
                ShoppingCart shoppingCart = new ShoppingCart
                {

                    Product_Id = productId,
                    User_Id = user,
                    Quantity = quantity,
                    Total = sc.Total,

                };
                scm.Add(shoppingCart);
            }
            scm.Context.SaveChanges();
            return "hola";
        }
    }
}
