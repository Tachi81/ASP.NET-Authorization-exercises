using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PageWithLoggingIn.Startup))]
namespace PageWithLoggingIn
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
