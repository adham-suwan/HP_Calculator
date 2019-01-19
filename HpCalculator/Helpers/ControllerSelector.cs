using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Dispatcher;

namespace HpCalculator.Helpers
{
    public class ControllerSelector : DefaultHttpControllerSelector
    {

        private HttpConfiguration _config;
        public ControllerSelector(HttpConfiguration config)
            : base(config)
        {
            _config = config;
        }

        public override System.Web.Http.Controllers.HttpControllerDescriptor SelectController(HttpRequestMessage request)
        {
            HttpControllerDescriptor versioneddescriptor;

            var controllers = GetControllerMapping();
            var routeData = request.GetRouteData();
            var controllerName = (string)routeData.Values["controller"];
            var version = (string)routeData.Values["version"];

            var newName = string.Concat(controllerName, "V", version);
            if (controllers.TryGetValue(newName, out versioneddescriptor))
            {
                return versioneddescriptor;
            }

            return base.SelectController(request);
        }
    }
}