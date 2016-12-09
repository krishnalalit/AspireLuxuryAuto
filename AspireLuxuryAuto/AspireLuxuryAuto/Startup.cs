using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AspireLuxuryAuto.Startup))]
namespace AspireLuxuryAuto
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
