using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace WebAPIHost
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            var config = GlobalConfiguration.Configuration;

            WebAPI.Config.RouteConfig.RegisterRoutes(config);
            WebAPI.Config.WebAPIConfig.Configure(config);

            config.EnsureInitialized();
        }
    }
}
