using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC5BootstrapDRAdmin.Startup))]
namespace MVC5BootstrapDRAdmin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
