using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Odabs.Startup))]
namespace Odabs
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
