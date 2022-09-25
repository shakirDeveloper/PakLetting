using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PakLetting.Web.Startup))]
namespace PakLetting.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
