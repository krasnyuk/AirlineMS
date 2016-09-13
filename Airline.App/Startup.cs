using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Airline.App.Startup))]
namespace Airline.App
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
