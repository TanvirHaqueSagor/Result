using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Result.Startup))]
namespace Result
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
