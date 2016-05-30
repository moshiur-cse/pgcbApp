using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(pgcbApp.Startup))]
namespace pgcbApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
