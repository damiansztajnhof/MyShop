using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyShop.NetUI.Startup))]
namespace MyShop.NetUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
