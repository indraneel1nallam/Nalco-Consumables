﻿using System.Web.Mvc;
using System.Web.Routing;

namespace Nalco_Consumables
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "index.html"
            );
        }
    }
}