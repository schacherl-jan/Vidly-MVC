using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Vidly
{
	public class RouteConfig
	{
		public static void RegisterRoutes(RouteCollection routes)
		{
			routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

			//custom routes	tonto zpusob nepouzivat, stringove action
			//lepti cesta pouzivat attribute routing
			//routes.MapRoute(
			//	"MovieByReleaseDate",
			//	"movies/released/{year}/{month}",
			//	new {controller = "Movies", action = "ByReleaseDate"});

			//attribute routing
			routes.MapMvcAttributeRoutes();


			routes.MapRoute(
				name: "Default",
				url: "{controller}/{action}/{id}",
				defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
			);
		}
	}
}
