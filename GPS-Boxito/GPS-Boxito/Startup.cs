using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GPS_Boxito.Startup))]
namespace GPS_Boxito
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
