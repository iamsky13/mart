using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace mart
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
                name: "Createshop",
                url: "shop/Createshop",
                defaults: new { controller = "shop", action = "Createshop" }
            );

            routes.MapRoute(
                name: "Createfolder",
                url: "shop/Createfolder",
                defaults: new { controller = "shop", action = "Createfolder" }
            );

            routes.MapRoute(
                name: "Defaulta",
                url: "shop/{id}",
                defaults: new {controller = "shop", action = "Index", id = UrlParameter.Optional }
            );

           
            routes.MapRoute(
               name: "Default",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
           );

           

            routes.MapRoute(
               name: "Defaulta1",
               url: "shop/explore/{sky}/{id}",
               defaults: new { controller = "shop", action = "sky", id = UrlParameter.Optional }
           );


           
        }
    }
}
