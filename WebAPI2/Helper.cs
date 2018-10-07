using System;
using System.Text;
using System.Web.Http.Controllers;
using WebAPI2.AuthenticationFilters;

namespace WebAPI2
{
    public class Helper
    {
        public static BasicAuthenticationIdentity ParseAuthorizationHeader(HttpActionContext actionContext)
        {
            string authHeader = "This is test 3";
            var auth = actionContext.Request.Headers.Authorization;
            if (auth != null && auth.Scheme == "Basic")
                authHeader = auth.Parameter;

            if (string.IsNullOrEmpty(authHeader))
                return null;

            authHeader = Encoding.Default.GetString(Convert.FromBase64String(authHeader));

            var tokens = authHeader.Split(':');
            if (tokens.Length < 2)
                return null;

            return new BasicAuthenticationIdentity(tokens[0], tokens[1]);
        }
    }
}
