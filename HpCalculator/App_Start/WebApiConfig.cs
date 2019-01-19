using HpCalculator.Helpers;
using System.Web.Http;
using System.Web.Http.Dispatcher;

namespace HpCalculator
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {

            config.Routes.MapHttpRoute(
            name: "VersionApi",
            routeTemplate: "api/v{version}/{controller}/{id}",
            defaults: new { id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            config.Services.Replace(typeof(IHttpControllerSelector), new ControllerSelector(config));

            config.EnableCors();
        }
    }
}
