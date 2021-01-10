using EShopOS.Core;
using EShopOS.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopOS.Application
{
    class OrderDetailManager : GenericManager<OrderDetail>
    {
        /// <summary>
        /// Constructor de Manager Pedido
        /// </summary>
        /// <param name="context">Contexto de datos</param>
        public OrderDetailManager(ApplicationDbContext context) : base(context)
        {

        }

        public IQueryable<Product> GetByProduct(int productId)
        {
            return Context.Products.Where(e => e.Id == productId);
        }



    }
}