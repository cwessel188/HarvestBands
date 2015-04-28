using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace HarvestBands
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Directors",
                url: "Directors/{bandname}",
                defaults: new { controller = "Directors", action = "GetDirectorLogin" }
            );


            routes.MapRoute(
                name: "Schedule",
                url: "schedule",
                defaults: new { controller = "Schedule" }
                );


            routes.MapRoute(
                name: "PastFestivals",
                url: "{pastyear}",
                defaults: new { controller = "PastFestivals", action = "GetPastFestivalByYear" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
