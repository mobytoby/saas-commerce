using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SaaSCommerce.Startup))]
namespace SaaSCommerce
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
