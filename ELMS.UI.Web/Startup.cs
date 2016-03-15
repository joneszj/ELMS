using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ELMS.UI.Web.Startup))]
namespace ELMS.UI.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
