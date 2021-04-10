using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hotel_Reservation_Manager.Startup))]
namespace Hotel_Reservation_Manager
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
