using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SimpleIdentity.Startup))]
namespace SimpleIdentity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
