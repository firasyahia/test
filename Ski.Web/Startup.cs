using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ski.Web.Startup))]
namespace Ski.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
