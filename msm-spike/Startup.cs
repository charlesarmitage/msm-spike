using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(msm_spike.Startup))]
namespace msm_spike
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
