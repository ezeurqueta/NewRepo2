using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen; 

namespace WebAPIAutores.Utilidades
{
    public class AgregarParametroXVersion : IOperationFilter
    {
        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {
            if (context.ApiDescription.HttpMethod != "GET")
            {
                return;
            }

            if (operation.Parameters == null)
            {
                operation.Parameters = new List<OpenApiParameter>();
            }

            operation.Parameters.Add(new OpenApiParameter
            {
                Name = "x-version",
                In = ParameterLocation.Header,
                Required = true
            });
        }
    }
}