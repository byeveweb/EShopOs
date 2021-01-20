using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopOS.Core
{
    public class Product
    {
       
        /// <summary>
        /// Identificador del Producto
        /// </summary>
        public int Id { get; set; }


        /// <summary>
        /// Nombre del producto
        /// </summary>
        public string NameProduct { get; set; }


        /// <summary>
        /// Description del producto
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Percio del producto
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Existencias
        /// </summary>
        public int Stock { get; set; }

        /// <summary>
        /// EStado del producto Pedido (Disponible o no disponible)
        /// </summary>
        public ProductStatus ProductStatus { get; set; }
    }
}
