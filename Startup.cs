using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Coredesignstemp1.Startup))]
namespace Coredesignstemp1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
