using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TEER.Startup))]
namespace TEER
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
