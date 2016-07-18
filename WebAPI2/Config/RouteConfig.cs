﻿using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Dispatcher;
using System.Web.Http.Routing;
using WebAPI2.Dispatchers;

namespace WebAPI.Config
{
    public class RouteConfig
    {
        public static void RegisterRoutes(HttpConfiguration config)
        {
            // Pipelines
            HttpMessageHandler demoPipeline =
                HttpClientFactory.CreatePipeline(
                    new HttpControllerDispatcher(config),
                    new[] { new DemoDispatcher() });

            var routes = config.Routes;

            routes.MapHttpRoute(
                "DemoDispatcherRoute",
                "api/{controller}/{id}/details",
                defaults: new { controller = "Websites", id = RouteParameter.Optional },
                constraints: null,
                handler: demoPipeline);


            routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
