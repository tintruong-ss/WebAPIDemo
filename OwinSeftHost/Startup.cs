using Owin;
using System.Web.Http;

namespace OwinSeftHost
{
    public class Startup
    {
        // This code configures Web API. The Startup class is specified as a type
        // parameter in the WebApp.Start method.
        public void Configuration(IAppBuilder appBuilder)
        {
            // Configure Web API for self-host. 
            HttpConfiguration config = new HttpConfiguration();
            WebAPI.Config.WebAPIConfig.Configure(config);
            WebAPI.Config.RouteConfig.RegisterRoutes(config);
            appBuilder.UseWebApi(config);
        }
    }
}
