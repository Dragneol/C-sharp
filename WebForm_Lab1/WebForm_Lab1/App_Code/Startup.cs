using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebForm_Lab1.Startup))]
namespace WebForm_Lab1
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
