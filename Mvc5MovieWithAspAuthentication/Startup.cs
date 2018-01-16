using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mvc5MovieWithAspAuthentication.Startup))]
namespace Mvc5MovieWithAspAuthentication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
