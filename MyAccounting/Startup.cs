using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyAccounting.Startup))]
namespace MyAccounting
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
