using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProyectoIntegrado.Startup))]
namespace ProyectoIntegrado
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
