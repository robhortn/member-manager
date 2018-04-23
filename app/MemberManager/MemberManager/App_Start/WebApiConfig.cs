using System.Configuration;
using System.Web.Http;
using System.Web.Http.Cors;

namespace MemberManager
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Global configuration cross origin site scripting
            var cors = new EnableCorsAttribute(GetAllowedOrigins(), "*", "*");
            config.EnableCors(cors);

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }

        public static string GetAllowedOrigins() {
            var allowedOrigins = ConfigurationManager.AppSettings["AllowedOrigins"];
            if (allowedOrigins == null)
            {
                throw new ConfigurationErrorsException("Could not find AllowedOrigins in Web.Config file.");
            }
            return allowedOrigins;
        }
    }
}
