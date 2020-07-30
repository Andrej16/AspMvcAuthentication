using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_8Authentication.Startup))]
namespace _8Authentication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
