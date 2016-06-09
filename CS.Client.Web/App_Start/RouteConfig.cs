using System.Web.Mvc;
using System.Web.Routing;

namespace CS.Client.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "client_details",
                url: "client/{id}",
                defaults: new { controller = "Client", action = "Client"}
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}",
                defaults: new { controller = "Client", action = "Clients", id = UrlParameter.Optional }
            );
        }
    }
}
