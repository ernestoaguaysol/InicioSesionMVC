using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InicioSesionMVC.Startup))]
namespace InicioSesionMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
