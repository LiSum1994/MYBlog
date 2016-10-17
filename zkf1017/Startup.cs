using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(zkf1017.Startup))]
namespace zkf1017
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
