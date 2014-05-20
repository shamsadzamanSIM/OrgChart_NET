using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Orgchart.Web.Startup))]
namespace Orgchart.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
