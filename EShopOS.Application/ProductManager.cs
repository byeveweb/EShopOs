using EShopOS.Core;
using EShopOS.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopOS.Application
{
   public class ProductManager : GenericManager<Product>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"></param>
        public ProductManager(ApplicationDbContext context)
            : base(context)
        {

        }
    }
}

