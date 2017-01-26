﻿using System.Collections.Generic;
using System.Reflection;
using Digipolis.Web.Guidelines.Models;
using Swashbuckle.Swagger.Model;
using Swashbuckle.SwaggerGen.Generator;

namespace Digipolis.Web.Guidelines.Swagger
{
    internal class PagedResultSchemaFilter : ISchemaFilter
    {
        public void Apply(Schema model, SchemaFilterContext context)
        {
            if (!context.SystemType.GetTypeInfo().IsGenericType || context.SystemType.GetGenericTypeDefinition() != typeof(PagedResult<>))
                return;

            var links = model.Properties["_links"];
            var embedded = new Schema
            {
                Properties = new Dictionary<string, Schema>()
                {
                    {"resourceList", model.Properties["data"]}
                },
                Type = "object"
            };
            var page = model.Properties["_page"];


            model.Properties = new Dictionary<string, Schema>
            {
                { "_links", links},
                { "_embedded", embedded},
                { "_page", page}
            };
        }
    }
}