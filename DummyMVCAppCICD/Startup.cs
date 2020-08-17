using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DummyMVCAppCICD.Startup))]
namespace DummyMVCAppCICD
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
