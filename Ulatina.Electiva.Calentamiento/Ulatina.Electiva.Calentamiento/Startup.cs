using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ulatina.Electiva.Calentamiento.Startup))]
namespace Ulatina.Electiva.Calentamiento
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
