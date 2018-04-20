using System.Web.Http;
using SeverApplication;
using Swashbuckle.Application;
using Swashbuckle.AutoRestExtensions;
using Swashbuckle.Swagger;
using WebActivatorEx;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace SeverApplication
{
    public class SwaggerConfig
    {
        public static void Register()
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;

            GlobalConfiguration.Configuration
                .EnableSwagger(c =>
                    {
                        c.MapType<decimal>(() => new Schema { type = "number", format = "decimal" });
                        c.SingleApiVersion("v1", "SeverApplication");
                        c.ApplyAutoRestFilters(
                            new SwaggerDocsConfigExtensionsConfiguration
                            {
                                ApplyEnumTypeSchemaFilter = true,
                                ApplyNullableTypeSchemaFilter = true,
                                ApplyNonNullableAsRequiredSchemaFilter = true
                            },
                            null);
                        c.DescribeAllEnumsAsStrings(true);
                    })
                .EnableSwaggerUi(c =>
                    {
                    });
        }
    }
}
