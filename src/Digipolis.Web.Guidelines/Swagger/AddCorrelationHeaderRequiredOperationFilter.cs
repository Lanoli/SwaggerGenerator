using System;
using System.Collections.Generic;
using System.Linq;
using Swashbuckle.Swagger;
using Swashbuckle.Swagger.Model;
using Swashbuckle.SwaggerGen.Generator;

namespace Digipolis.Persoon.Api.Swagger
{
    public class AddCorrelationHeaderRequiredOperationFilter : IOperationFilter
    {
        public void Apply(Operation operation, OperationFilterContext context)
        {
            if (operation.Parameters == null)
                operation.Parameters = new List<IParameter>();


            operation.Parameters.Add(new NonBodyParameter
            {
                Name = "Dgp-Correlation",
                Description = @"Correlation info
                base64 encoded :

                {
                    ""id"":""string"",
                    ""source"":""string"",
                    ""userId"":""string"",
                    ""ipAdress"":""string""
                }",
                Type = "string",
                Required = true,
                In = "header"
            });
        }
    }
}
