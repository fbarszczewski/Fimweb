using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Fimweb.Startup))]
namespace Fimweb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
