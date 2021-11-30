using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LibrarySite.Startup))]
namespace LibrarySite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
