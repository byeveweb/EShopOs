using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopOS.Core
{
    /// <summary>
    /// Enumerado del estado del producto
    /// </summary>
    public enum ProductStatus : int
    {

        /// <summary>
        /// Disponible
        /// </summary>
        Enable = 1,

        /// <summary>
        /// No disponible
        /// </summary>
        Disable = 0,
    }
}
