using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ICTProject.Startup))]
namespace ICTProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
