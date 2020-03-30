using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using webApiTest.Middleware.Extensions.Swagger.Options;

namespace webApiTest.Middleware.Extensions.Swagger
{
    public static class SwaggerExtension
    {
        public static void SwaggerGenExt(this IServiceCollection services)
        {
            services.AddSwaggerGen(c=>{
                c.SwaggerDoc("v1", new OpenApiInfo(){ Title ="Test Api", Version = "v1"});
            });
        }

        public static void SwaggerUIExt(this IApplicationBuilder app, IConfiguration configuration)
        {
            var swaggerOptions = new SwaggerOptions();
            configuration.GetSection(nameof(SwaggerOptions)).Bind(swaggerOptions);

            app.UseSwagger(op =>{ op.RouteTemplate = swaggerOptions.JsonRoute; });
            app.UseSwaggerUI(c=>{
                 c.SwaggerEndpoint(swaggerOptions.UIEndpoint, swaggerOptions.Description);
            });
        }
    }
}