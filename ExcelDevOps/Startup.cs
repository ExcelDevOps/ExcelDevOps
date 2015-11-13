using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExcelDevOps.Startup))]
namespace ExcelDevOps
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
