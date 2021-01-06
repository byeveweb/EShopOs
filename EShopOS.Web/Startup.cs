using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EShopOS.Web.Startup))]
namespace EShopOS.Web
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
