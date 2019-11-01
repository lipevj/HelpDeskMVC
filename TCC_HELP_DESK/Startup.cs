using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TCC_HELP_DESK.Startup))]
namespace TCC_HELP_DESK
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
