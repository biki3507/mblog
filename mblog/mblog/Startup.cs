using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mblog.Startup))]
namespace mblog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
