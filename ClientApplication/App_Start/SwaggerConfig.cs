using System.Web.Http;
using ClientApplication;
using Swashbuckle.Application;
using Swashbuckle.AutoRestExtensions;
using WebActivatorEx;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace ClientApplication
{
    public class SwaggerConfig
    {
        public static void Register()
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;

            GlobalConfiguration.Configuration
                .EnableSwagger(c =>
                    {
                        c.SingleApiVersion("v1", "ClientApplication");
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
