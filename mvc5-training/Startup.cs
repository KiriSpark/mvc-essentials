using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mvc5_training.Startup))]
namespace mvc5_training
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
