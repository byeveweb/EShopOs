using EShopOS.Core;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopOS.DAL
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
        /// <summary>
        /// Crear coleccion de productos
        /// </summary>
        public DbSet<Product> Products { get; set; }


        /// <summary>
        /// Crear coleccion de Pedidos
        /// </summary>
        public DbSet<Order> Order { get; set; }

        
    }
}
