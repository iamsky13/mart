using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mart.Startup))]
namespace mart
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
