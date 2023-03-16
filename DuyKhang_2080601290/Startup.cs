using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DuyKhang_2080601290.Startup))]
namespace DuyKhang_2080601290
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
