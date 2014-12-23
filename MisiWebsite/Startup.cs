using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MisiWebsite.Startup))]
namespace MisiWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
