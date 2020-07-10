using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(variableSession.Startup))]
namespace variableSession
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
