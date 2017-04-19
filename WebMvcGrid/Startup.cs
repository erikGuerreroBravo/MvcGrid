using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebMvcGrid.Startup))]
namespace WebMvcGrid
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
