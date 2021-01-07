using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopOS.Core
{

    /// <summary>
    /// Entidad Detalle del Pedido
    /// </summary>
   public class OrderDetail
    {
        /// <summary>
        /// Identificador del Detalle del Pedido
        /// </summary>
        public int Id { get; set; }


        /// <summary>
        /// Id al que pertenece el pedido, desde Orders
        /// </summary>
        public Order Order { get; set; }

        /// <summary>
        /// Creamos la relación entre ambas tablas, trayendo el Id del Order
        /// </summary>
        [ForeignKey("Order")]
        public int Order_Id { get; set; }
        /// <summary>
        /// Colección de productos
        /// </summary>
       public virtual List<Product> Products { get; set; }

        /// <summary>
        /// Cantidad de productos
        /// </summary>
        public int Quantity { get; set; }

    }
}
