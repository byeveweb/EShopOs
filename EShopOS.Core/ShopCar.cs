using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopOS.Core
{
    public class ShopCar
    {
        /// <summary>
        /// Identificador del Pedido
        /// </summary>
        public int Id { get; set; }

        /// </summary>
        /// Usuario al que pertenece el carrito, desde Application User
        /// </summary>
        public ApplicationUser User { get; set; }

        /// <summary>
        /// Creamos la relación entre ambas tablas, trayendo el Id del User
        /// </summary>
        [ForeignKey("User")]
        public string User_Id { get; set; }


        /// </summary>
        /// Usuario al que pertenece el carrito, desde Application User
        /// </summary>
        public Product Product { get; set; }

        /// <summary>
        /// Creamos la relación entre ambas tablas, trayendo el Id del producto
        /// </summary>
        [ForeignKey("Product")]
        public int Product_Id { get; set; }



        /// <summary>
        /// Cantidad por producto
        /// </summary>
        public int Quantity { get; set; }


        /// <summary>
        /// Total de la compra esta es la suma de de los precios del producto
        /// </summary>
        public Decimal TotalPrice { get; set; }

    }
}
