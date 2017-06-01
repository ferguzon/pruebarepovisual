using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(proyectopruebarepovisual.Startup))]
namespace proyectopruebarepovisual
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
