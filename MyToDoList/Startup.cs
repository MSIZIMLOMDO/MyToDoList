using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyToDoList.Startup))]
namespace MyToDoList
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
