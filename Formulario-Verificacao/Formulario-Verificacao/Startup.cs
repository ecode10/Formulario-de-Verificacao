using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Formulario_Verificacao.Startup))]
namespace Formulario_Verificacao
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
