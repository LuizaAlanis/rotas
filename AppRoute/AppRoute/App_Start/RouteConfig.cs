using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace AppRoute
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Noticia",
                url: "noticias/{categoria}/{titulo}--{noticiaId}",
                defaults: new { controller = "Home", action = "MostrarNoticia", id = UrlParameter.Optional },
                namespaces: new[] { "AppRoute.Controllers" }
            );

            routes.MapRoute(
                name: "Categoria Especifica",
                url: "noticias/{categoria}",
                defaults: new { controller = "Home", action = "MostrarCategoria", id = UrlParameter.Optional },
                namespaces: new[] { "AppRoute.Controllers" }
            );

            routes.MapRoute(
                name: "Todas as noticias",
                url: "noticias/",
                defaults: new { controller = "Home", action = "Notica", id = UrlParameter.Optional },
                namespaces: new[] { "AppRoute.Controllers" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "AppRoute.Controllers" }
            );
        }
    }
}
