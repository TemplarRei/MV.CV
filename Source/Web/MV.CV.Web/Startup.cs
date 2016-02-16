using Microsoft.Owin;

using Owin;

[assembly: OwinStartupAttribute(typeof(MV.CV.Web.Startup))]

namespace MV.CV.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            this.ConfigureAuth(app);
        }
    }
}
