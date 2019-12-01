using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SportHub.Startup))]
namespace SportHub
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
