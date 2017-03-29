using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NEOOG.Startup))]
namespace NEOOG
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
