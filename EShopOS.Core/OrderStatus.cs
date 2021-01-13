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
        /// En proceso
        /// </summary>
        Process = 1,

        /// <summary>
        /// Cerrado
        /// </summary>
        Close = 2,

    }
}
