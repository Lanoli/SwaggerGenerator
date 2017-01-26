using Swashbuckle.Swagger;
using Swashbuckle.SwaggerGen.Generator;
using System;
using System.Collections.Generic;
using System.Linq;
using Swashbuckle.Swagger.Model;

namespace Digipolis.Persoon.Api.Swagger
{
    public class AddExternalDocInfoDocumentFilter : IDocumentFilter
    {
        public string Url { get; set; }

        public string Description { get; set; }

        public AddExternalDocInfoDocumentFilter(string url, string description)
        {
            this.Url = url;
            this.Description = description;
        }

        public void Apply(SwaggerDocument swaggerDoc, DocumentFilterContext context)
        {
            swaggerDoc.ExternalDocs = new ExternalDocs()
            {
                Url = this.Url,
                Description = this.Description
             
            };
        }

    }
}
