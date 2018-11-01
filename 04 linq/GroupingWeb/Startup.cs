using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GroupingWeb.Startup))]
namespace GroupingWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
