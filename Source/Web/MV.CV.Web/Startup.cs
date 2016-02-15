using Microsoft.Owin;

using Owin;

[assembly: OwinStartupAttribute(typeof(Mvcv.Web.Startup))]

namespace Mvcv.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            this.ConfigureAuth(app);
        }
    }
}
