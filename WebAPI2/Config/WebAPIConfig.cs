using System.Linq;
using System.Web.Http;
using WebAPI2.MessageHandlers;

namespace WebAPI.Config
{
    public class WebAPIConfig
    {
        public static void Configure(HttpConfiguration config)
        {
            //config.EnableCors();

            // Message Handlers
            //config.MessageHandlers.Add(new RequireHttpsMessageHandler());
            config.MessageHandlers.Add(new DummyMessageHandler());

            // Add global authorization
            //config.Filters.Add(new AuthorizeAttribute());

            // Web API routes
            config.MapHttpAttributeRoutes();

            // Return Json as default
            //var appXmlType = config.Formatters.XmlFormatter.SupportedMediaTypes.FirstOrDefault(t => t.MediaType == "application/xml");
            //config.Formatters.XmlFormatter.SupportedMediaTypes.Remove(appXmlType);
        }
    }
}
