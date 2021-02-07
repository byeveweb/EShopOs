using EShopOS.Core;
using EShopOS.DAL;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace EShopOS.Web
{
    public class Global : HttpApplication
    {
        //Configuración de seguridad
        ApplicationDbContext context = new ApplicationDbContext();
        

        void Application_Start(object sender, EventArgs e)
        {
            // Código que se ejecuta al iniciar la aplicación
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            RoleManager<IdentityRole> roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            UserManager<ApplicationUser> userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

            string RolAdmin = "Admin";
            string RolUSer = "User";


            if (!roleManager.RoleExists(RolAdmin))
            {
                roleManager.Create(new IdentityRole(RolAdmin));
            }

            if(!roleManager.RoleExists(RolUSer))
            {
                roleManager.Create(new IdentityRole(RolUSer));
            }
        }
    }
}