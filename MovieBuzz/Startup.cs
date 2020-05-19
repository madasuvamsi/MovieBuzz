using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MovieBuzz.Startup))]
namespace MovieBuzz
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
