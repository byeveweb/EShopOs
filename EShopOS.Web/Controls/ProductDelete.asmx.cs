using EShopOS.Application;
using EShopOS.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;

namespace EShopOS.Web.Controls
{
    /// <summary>
    /// Descripción breve de ProductDelete
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    [ScriptService]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class ProductDelete : System.Web.Services.WebService
    {
        ApplicationDbContext context = null;
        readonly OrderDetailManager orderDetailManager = null;

        [WebMethod]
        [ScriptMethod()]
        public string DeleteProduct(int orderId)
        {

            context = new ApplicationDbContext();
            OrderManager ordm = new OrderManager(context);
            OrderDetailManager orderDetailManager = new OrderDetailManager(context);


            //Traemos el Id de la ORd
            var pr = ordm.GetById(orderId);
            var ordts = orderDetailManager.GetAll().Where(e => e.Order_Id == orderId);


            if (ordts != null)
            {
                return "Hola a todos";
            }
            else
            {
                foreach( var od in ordts)
                {
                    orderDetailManager.Remove(od); 
                }
            }
         
            return "Hola a todos";
        }
    }
}
