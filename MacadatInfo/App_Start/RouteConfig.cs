using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MacadatInfo
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new
                {
                    // Change "Home" to your custom controller name
                    controller = "Macadat241678Home",

                    // Change "Index" to your custom action name
                    action = "Macadat241678Index",

                    id = UrlParameter.Optional
                }
            );
        }
    }
}
