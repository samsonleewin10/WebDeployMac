using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(hkboygod1203.Startup))]
namespace hkboygod1203
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
