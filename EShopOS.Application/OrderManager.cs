using EShopOS.Core;
using EShopOS.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopOS.Application
{
    public class OrderManager : GenericManager<OrderManager>
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
        /// Traemos a través del método GetByShopCarId el Id del producto
        /// </summary>
        /// <param name="shopCarId">el id del Carrito</param>
        /// <returns>Carrito del producto</returns>
        public IQueryable<ShopCar> GetByShopCartId(int shopCarId)
        {
            return Context.Set<ShopCar>().Where(e => e.Id == shopCarId);
        }
    }
}

