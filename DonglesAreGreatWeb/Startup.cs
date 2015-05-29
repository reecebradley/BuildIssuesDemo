using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DonglesAreGreatWeb.Startup))]
namespace DonglesAreGreatWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
