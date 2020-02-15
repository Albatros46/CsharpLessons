using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Hemsehrim
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Anasayfa",
                url: "{Departman}/{Index}",
                defaults: new { controller = "Departman", action = "Index"}
            );
            routes.MapRoute(
               name: "Personel",
               url: "{Personel}/{Index}",
               defaults: new { controller = "Personel", action = "Index" }
           );
        }
    }
}
