using Swashbuckle.Swagger;
using Swashbuckle.SwaggerGen.Generator;
using System;
using System.Collections.Generic;
using System.Linq;
using Swashbuckle.Swagger.Model;

namespace Digipolis.Persoon.Api.Swagger
{
    public class AddCorrelationheaderRequiredDocumentFilter : IDocumentFilter
    {


        public void Apply(SwaggerDocument swaggerDoc, DocumentFilterContext context)
        {

            if (swaggerDoc.Parameters == null)
                swaggerDoc.Parameters = new Dictionary<String, IParameter>();

            swaggerDoc.Parameters.Add("test", new NonBodyParameter
            {
                Name = "test",
                Description = "test",
                Type = "string",
                Required = true
            });

            swaggerDoc.Parameters.Add("Dgp-Correlation", new NonBodyParameter
            {
                Name = "Dgp-Correlation",
                Description = "correlation header",
                Type = "string",
                Required = true
            });

            //if (operation.Parameters == null)
            //    operation.Parameters = new List<IParameter>();


            //operation.Parameters.Add(new NonBodyParameter
            //{
            //    Name = "Dgp-Correlation",
            //    Description = "correlation header",
            //    Type = "string",
            //    Required = true
            //});
        }

    }
}
