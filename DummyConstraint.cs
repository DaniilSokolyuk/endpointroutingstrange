using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace EndpointRoutingStrange
{
    public class DummyConstraint : IRouteConstraint
    {
        public bool Match(HttpContext httpContext, IRouter route, string parameterName, RouteValueDictionary values, RouteDirection routeDirection)
        {
            return false;
        }
    }
}
