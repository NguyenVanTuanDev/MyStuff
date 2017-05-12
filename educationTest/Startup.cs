using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(educationTest.Startup))]
namespace educationTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
