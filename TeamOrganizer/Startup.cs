using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TeamOrganizer.Startup))]
namespace TeamOrganizer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
