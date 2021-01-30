using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopOS.Core
{
    public class OrderDetail
    {
        /// <summary>
        /// Identificador del Pedido
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Identificador del usuario que ha escrito el mensaje
        /// </summary>
        [ForeignKey("Order")]
        public int Order_Id { get; set; }

        /// <summary>
        /// Usuario que ha creado la incidencia
        /// </summary>
        public Order Order { get; set; }


        /// <summary>
        /// Identificador del usuario que ha escrito el mensaje
        /// </summary>
        [ForeignKey("Product")]
        public int Product_Id { get; set; }

        /// <summary>
        /// Usuario que ha creado la incidencia
        /// </summary>
        public Product Product { get; set; }

        /// <summary>
        /// Percio del producto
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Existencias
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Existencias
        /// </summary>
        public int Total { get; set; }



    }
}
