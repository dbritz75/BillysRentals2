using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(BillysRentals2.StartupOwin))]

namespace BillysRentals2
{
    public partial class StartupOwin
    {
        public void Configuration(IAppBuilder app)
        {
            //AuthStartup.ConfigureAuth(app);
        }
    }
}
