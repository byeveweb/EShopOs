using EShopOS.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopOS.Application
{
    class CostumerData : GenericManager<CostumerData>
    {
        /// <summary>
        /// Constructor de Manager Detalle del pedido
        /// </summary>
        /// <param name="context">Contexto de datos</param>
        public CostumerData(ApplicationDbContext context) : base(context)
        {

        }



    }
}