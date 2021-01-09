using EShopOS.Core;
using EShopOS.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopOS.Application
{
    class ProductManager : GenericManager<Product>
    {
        /// <summary>
        /// Constructor de Manager Producto
        /// </summary>
        /// <param name="context">Contexto de datos</param>
        public ProductManager(ApplicationDbContext context) : base(context)
        {

        }


       
    }
}