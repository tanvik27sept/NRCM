using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NRCM.Startup))]
namespace NRCM
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
