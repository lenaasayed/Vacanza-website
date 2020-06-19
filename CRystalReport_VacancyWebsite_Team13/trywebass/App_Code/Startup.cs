using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(trywebass.Startup))]
namespace trywebass
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
