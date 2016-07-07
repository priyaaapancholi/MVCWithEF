using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCWithEF.Startup))]
namespace MVCWithEF
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
