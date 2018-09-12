using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mon_fall1018_10_sept.Startup))]
namespace mon_fall1018_10_sept
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
