using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopOS.Core
{
    /// <summary>
    /// Entidad: Modelo datos personales del Cliente
    /// </summary>
    public class CostumerData
    {

        /// <summary>
        /// Identificador del DatosCliente
        /// </summary>
        public int Id { get; set; }


        /// <summary>
        /// Nombre del cliente
        /// </summary>
        public string FirstName { get; set; }


        /// <summary>
        /// Apellido del cliente
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// DNI del cliente
        /// </summary>
        public string DocumentIdentityNumber { get; set; }

        /// <summary>
        /// Calle del cliente
        /// </summary>
        public string PostalAddress { get; set; }

        /// <summary>
        /// Ciudad del cliente
        /// </summary>
        public string City{ get; set; }

        /// <summary>
        /// Provincia del cliente
        /// </summary>
        public string Province { get; set; }

        /// <summary>
        /// Código postañ del cliente
        /// </summary>
        public int PostalCode{ get; set; }


        /// <summary>
        /// Usuario al que pertenece la dirección, desde Application User
        /// </summary>
        public ApplicationUser User { get; set; }

        /// <summary>
        /// Creamos la relación entre ambas tablas, trayendo el Id del User
        /// </summary>
        [ForeignKey("User")]
        public string User_Id { get; set; }
    }
}
