using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Log4Net.Startup))]
[assembly: log4net.Config.XmlConfigurator(ConfigFile = "Web.config", Watch = true)]
namespace Log4Net
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
