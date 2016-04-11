using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VL.MVC.Startup))]
namespace VL.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
