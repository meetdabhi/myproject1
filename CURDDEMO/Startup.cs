using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CURDDEMO.Startup))]
namespace CURDDEMO
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
