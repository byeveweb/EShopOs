using EShopOS.Core;
using EShopOS.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopOS.Application
{
    public class ShoppingCartManager : GenericManager<ShoppingCart>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"></param>
        public ShoppingCartManager(ApplicationDbContext context)
            : base(context)
        {

        }


        /// <summary>
        /// Obtiene todas las incidencias de un usuario
        /// </summary>
        /// <param name="userId">Identificador de usuario</param>
        /// <returns>Incidencias del usuario</returns>
        //public IQueryable<ShoppingCart> GetByUser(string userId)
        //{
        //    return Context.shoppingCarts.Where(e => e.User_Id == userId);
        //}
    }
}