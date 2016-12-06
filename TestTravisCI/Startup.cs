using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestTravisCI.Startup))]
namespace TestTravisCI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
