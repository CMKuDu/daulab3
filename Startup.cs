using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab3_TranDau.Startup))]
namespace Lab3_TranDau
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
