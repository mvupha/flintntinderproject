using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FlintnTinder.Startup))]
namespace FlintnTinder
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
