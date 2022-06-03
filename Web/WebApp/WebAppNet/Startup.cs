using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppNet.Startup))]
namespace WebAppNet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
