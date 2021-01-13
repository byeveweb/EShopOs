using EShopOS.Core;
using EShopOS.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopOS.Application
{
    public class ShopCarManager : GenericManager<ShopCar>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"></param>
        public ShopCarManager(ApplicationDbContext context)
            :base(context)
        {

        }
        /// <summary>
        /// Traemos a través del método GetByProductId el Id del producto
        /// </summary>
        /// <param name="productId">el id del producto</param>
        /// <returns>Id del producto</returns>
        public IQueryable<Product> GetByProductId(int productId)
        {
            return Context.Set<Product>().Where(e => e.Id == productId);
        }
    }
}
