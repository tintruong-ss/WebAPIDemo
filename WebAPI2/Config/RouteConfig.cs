using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Dispatcher;
using System.Web.Http.Routing;

namespace WebAPI.Config
{
    public class RouteConfig
    {
        public static void RegisterRoutes(HttpConfiguration config)
        {
            var routes = config.Routes;

            config.EnableCors();

            routes.MapHttpRoute("DefaultApiWithId",
                                "Api/{controller}/{id}",
                                new { id = RouteParameter.Optional }, new { id = @"\d+" });

            routes.MapHttpRoute("DefaultApiWithAction",
                                "Api/{controller}/{action}");

            routes.MapHttpRoute("DefaultApiActionWithId",
                                "Api/{controller}/{action}/{id}",
                                new { id = RouteParameter.Optional },
                                new { id = @"\d+" });

            routes.MapHttpRoute("DefaultApiGet", 
                                "Api/{controller}",
                                new { action = "Get" },
                                new { httpMethod = new HttpMethodConstraint(HttpMethod.Get) });

            routes.MapHttpRoute("DefaultApiPost",
                                "Api/{controller}",
                                new { action = "Post" },
                                new { httpMethod = new HttpMethodConstraint(HttpMethod.Post) }
                                //, new AuthorizeHandler()  // this will apply just to this route
                                //{
                                //    InnerHandler = new HttpControllerDispatcher(config)
                                //}
                                );
        }
    }
}
