using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(XDblogs.Startup))]
namespace XDblogs
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
