using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StatsTI2.Startup))]
namespace StatsTI2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
