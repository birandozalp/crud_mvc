using Microsoft.Owin;
using Owin;
using VoyagerYBusiness;

[assembly: OwinStartupAttribute(typeof(VoyagerYMVC.Startup))]
namespace VoyagerYMVC
{
    
    public partial class Startup
    {
        public static App webApp = new App();

        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            webApp.busService.ListChanged += new ListChangeHandler(RefreshList);
        }
        public void RefreshList()
        {

        }
    }
}
