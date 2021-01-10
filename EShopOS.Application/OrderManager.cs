﻿using EShopOS.Core;
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
        /// Constructor de Manager Detalle del pedido
        /// </summary>
        /// <param name="context">Contexto de datos</param>
        public OrderManager(ApplicationDbContext context) : base(context)
        {

        }



    }
}
