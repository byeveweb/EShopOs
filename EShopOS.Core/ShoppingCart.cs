﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopOS.Core
{

    /// <summary>
    /// Contendrá los productos añadidos al carrito. Sólo cotemplará lo relacionado con los artículos y no con la orden.
    /// </summary>
    public class ShoppingCart
    {   
        /// <summary>
        /// Id del Carrito
        /// </summary>
        public int Id { get; set; }



        /// <summary>
        /// Id del usuario que está comprando
        /// </summary>
        [ForeignKey("User")]
        public string User_Id { get; set; }
        public ApplicationUser User { get; set; }


        /// <summary>
        /// Id de los productos que se añaden al carrito
        /// </summary>
        [ForeignKey("Product")]
        public int Product_Id { get; set; }
        public Product Product { get; set; }



        /// <summary>
        /// Cantidad de articulos añadidos a la cesta
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Cantidad de articulos añadidos a la cesta
        /// </summary>
        public decimal Total { get; set; }

    }
}
