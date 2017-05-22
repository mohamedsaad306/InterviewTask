using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HossamTask.Web.Startup))]
namespace HossamTask.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
