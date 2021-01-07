using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopOS.Core
{
    /// <summary>
    /// Enumerado del estado del pedido
    /// </summary>
    public enum OrderStatus : int
    {

        /// <summary>
        /// Abierto
        /// </summary>
        Open = 0,

        /// <summary>
        /// Cerrado
        /// </summary>
        Cerrado = 1,
    }
}
