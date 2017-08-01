using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DockerAspApp.Startup))]
namespace DockerAspApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
