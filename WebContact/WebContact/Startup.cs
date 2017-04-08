using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebContact.Startup))]
namespace WebContact
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
