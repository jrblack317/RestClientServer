using System.Web.Http;

namespace SeverApplication
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();
        }
    }
}
