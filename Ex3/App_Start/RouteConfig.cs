using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Exercise3
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
            name: "save",
            url: "save/{ip1}.{ip2}.{ip3}.{ip4}/{port}/{time}/{duration}/{nameFile}",
            defaults: new { controller = "files", action = "save", id = UrlParameter.Optional }
            );

            routes.MapRoute(
            name: "secand",
            url: "display/{ip1}.{ip2}.{ip3}.{ip4}/{port}/{time}",
            defaults: new { controller = "display", action = "secand", id = UrlParameter.Optional }
            );

            routes.MapRoute(
            name: "first",
            url: "display/{ip1}.{ip2:}.{ip3}.{ip4}/{port}",
            defaults: new { controller = "display", action = "first", id = UrlParameter.Optional }
           );
            routes.MapRoute(
             name: "display",
             url: "display/{nameFile}/{time}",
             defaults: new { controller = "files", action = "display", id = UrlParameter.Optional }
            );

        }
    }
}