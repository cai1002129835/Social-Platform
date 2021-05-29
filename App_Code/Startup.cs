using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(chatweb.Startup))]
namespace chatweb
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
