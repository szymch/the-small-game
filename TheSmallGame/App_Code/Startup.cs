using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TheSmallGame.Startup))]
namespace TheSmallGame
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
