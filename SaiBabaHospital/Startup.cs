using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SaiBabaHospital.Startup))]
namespace SaiBabaHospital
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
