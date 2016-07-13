using System.Linq;
using System.Web.Http;
using WebAPI2.MessageHandlers;

namespace WebAPI.Config
{
    public class WebAPIConfig
    {
        public static void Configure(HttpConfiguration config)
        {
            // Message Handlers
            //config.MessageHandlers.Add(new RequireHttpsMessageHandler());

            //config.EnableCors();

            // Add global authorization
            //config.Filters.Add(new AuthorizeAttribute());

            // Return Json as default
            var appXmlType = config.Formatters.XmlFormatter.SupportedMediaTypes.FirstOrDefault(t => t.MediaType == "application/xml");
            config.Formatters.XmlFormatter.SupportedMediaTypes.Remove(appXmlType);
        }
    }
}
