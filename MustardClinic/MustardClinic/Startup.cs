using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MustardClinic.Startup))]
namespace MustardClinic
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
