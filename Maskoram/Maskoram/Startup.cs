using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Maskoram.Startup))]
namespace Maskoram
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
