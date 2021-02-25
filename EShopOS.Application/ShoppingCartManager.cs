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

        public ShoppingCartManager(ApplicationDbContext context)
            : base(context)
        {

        }

      

    }
}