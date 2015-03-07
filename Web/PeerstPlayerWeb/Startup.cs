using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PeerstPlayerWeb.Startup))]
namespace PeerstPlayerWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
