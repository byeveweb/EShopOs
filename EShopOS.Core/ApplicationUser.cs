using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace EShopOS.Core
{
    /// <summary>
    /// Entidad de dominio Usuario
    /// </summary>
    public class ApplicationUser : IdentityUser
    {
        public ClaimsIdentity GenerateUserIdentity(UserManager<ApplicationUser> manager)
        {
            // Tenga en cuenta que authenticationType debe coincidir con el valor definido en CookieAuthenticationOptions.AuthenticationType
            var userIdentity = manager.CreateIdentity(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Agregar reclamaciones de usuario personalizadas aquí
            return userIdentity;
        }

        public Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            return Task.FromResult(GenerateUserIdentity(manager));
        }


        /// <summary>
        /// Nombre y apellidos del cliente
        /// </summary>
        public string NameAndSurname { get; set; }





        /// <summary>
        /// Calle del cliente
        /// </summary>
        public string PostalAddress { get; set; }

        /// <summary>
        /// Ciudad del cliente
        /// </summary>
        public string City { get; set; }



        /// <summary>
        /// Código postañ del cliente
        /// </summary>
        public int PostalCode { get; set; }
    }


}
