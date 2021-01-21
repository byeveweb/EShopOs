using EShopOS.Core;
using EShopOS.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopOS.Application
{
    public class OrderManager : GenericManager<Order>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"></param>
        public OrderManager(ApplicationDbContext context)
            : base(context)
        {

        }


        /// <summary>
        /// Obtiene todas las incidencias de un usuario
        /// </summary>
        /// <param name="userId">Identificador de usuario</param>
        /// <returns>Incidencias del usuario</returns>
        public IQueryable<Order> GetByUser(string userId)
        {
            return Context.Orders.Where(e => e.User_Id == userId);
        }

    }
}

