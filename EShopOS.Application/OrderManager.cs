using EShopOS.Core;
using EShopOS.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopOS.Application
{

    /// <summary>
    /// Manager de Pedido
    /// </summary>
    public class OrderManager :  GenericManager<Order>
    {
        /// <summary>
        /// Constructor de Manager Pedido
        /// </summary>
        /// <param name="context">Contexto de datos</param>
        public OrderManager(ApplicationDbContext context) : base(context)
        {

        }


        /// <summary>
        /// Métodod que retorna todos los prodctos de una order
        /// </summary>
        /// <param name="productId">Id del producto</param>
        /// <returns></returns>
        public IQueryable<Product> GetByProductId(int productId)
        {
            return Context.Set<Product>().Where(e => e.Id == productId);
        }

    }
}
