using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EShopOs.Startup))]
namespace EShopOs
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
