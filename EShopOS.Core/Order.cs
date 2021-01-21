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
        /// Fecha de Creación del pedido
        /// </summary>
        public DateTime CreatedDateOrder { get; set; }

   

        /// <summary>
        /// Estado del Pedido (Disponible o no disponible)
        /// </summary>
        public OrderStatus OrderStatus { get; set; }


        /// <summary>
        /// Identificador del usuario que ha escrito el mensaje
        /// </summary>
        [ForeignKey("User")]
        public string User_Id { get; set; }

        /// <summary>
        /// Usuario que ha creado la incidencia
        /// </summary>
        public ApplicationUser User { get; set; }

        /// <summary>
        /// Lista de mensajes
        /// </summary>
        public virtual List<Product> Products { get; set; }

    }
}

