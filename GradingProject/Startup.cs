using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GradingProject.Startup))]
namespace GradingProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
