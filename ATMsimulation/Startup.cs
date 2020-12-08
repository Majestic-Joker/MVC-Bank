using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ATMsimulation.Startup))]
namespace ATMsimulation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
