using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PSIC.Startup))]
namespace PSIC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
