using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopOS.Core
{

    /// <summary>
    /// Entidad Pedido
    /// </summary>
    public class Order
    {

        /// <summary>
        /// Identificador del Pedido
        /// </summary>
        public int Id { get; set; }


        /// <summary>
        /// Usuario al que pertenece el pedido, desde Application User
        /// </summary>
        public ApplicationUser User { get; set; }

        /// <summary>
        /// Creamos la relación entre ambas tablas, trayendo el Id del User
        /// </summary>
        [ForeignKey("User")]
        public string User_Id { get; set; }


        /// <summary>
        /// Fecha de Creación del pedido
        /// </summary>
        public DateTime? CreatedDateOrder { get; set; }

        /// <summary>
        /// Hora de Creación del pedido
        /// </summary>
        public DateTime? CreatedTimeOrder { get; set; }


        /// <summary>
        /// EStado del Pedido (Disponible o no disponible)
        /// </summary>
        public OrderStatus OrderStatus { get; set; }

        public virtual List<OrderDetail> OrderDetails { get; set; }
    }
}

