using System;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.Routing;

namespace WebAPI2.Dispatchers
{
    public class DemoDispatcher : DelegatingHandler
    {
        protected override Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request,
            CancellationToken cancellationToken)
        {

            // We know at this point that the {id} route variable has 
            // been supplied. Otherwise, we wouldn't be here. So, just get it.
            IHttpRouteData routeData = request.GetRouteData();
            var id = Convert.ToInt32(routeData.Values["id"]);

            if (id > 4)
            {
                return Task.FromResult(
                    request.CreateResponse(HttpStatusCode.NotFound));
            }

            return base.SendAsync(request, cancellationToken);
        }

    }
}
