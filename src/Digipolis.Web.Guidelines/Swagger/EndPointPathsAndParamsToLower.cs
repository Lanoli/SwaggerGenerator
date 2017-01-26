﻿using System.Collections.Generic;
using Digipolis.Web.Guidelines.Helpers;
using Swashbuckle.Swagger.Model;
using Swashbuckle.SwaggerGen.Generator;

namespace Digipolis.Web.Guidelines.Swagger
{
    internal class EndPointPathsAndParamsToLower : IDocumentFilter
    {
        public void Apply(SwaggerDocument swaggerDoc, DocumentFilterContext context)
        {
            var newPaths = new Dictionary<string, PathItem>();
            foreach (var path in swaggerDoc.Paths)
            {
                var res = HandlePath(path.Value);
                newPaths.Add(path.Key.ToLowerInvariant(), res);
            }
            swaggerDoc.Paths = newPaths;
        }

        private PathItem HandlePath(PathItem value)
        {
            value.Parameters = handleParameters(value.Parameters);
            if (value.Get != null) value.Get.Parameters = handleParameters(value.Get.Parameters);
            if (value.Post != null) value.Post.Parameters = handleParameters(value.Post.Parameters);
            if (value.Put != null) value.Put.Parameters = handleParameters(value.Put.Parameters);
            if (value.Patch != null) value.Patch.Parameters = handleParameters(value.Patch.Parameters);
            if (value.Delete != null) value.Delete.Parameters = handleParameters(value.Delete.Parameters);
            if (value.Head != null) value.Head.Parameters = handleParameters(value.Head.Parameters);
            if (value.Options != null) value.Options.Parameters = handleParameters(value.Options.Parameters);
            return value;
        }

        private IList<IParameter> handleParameters(IList<IParameter> parameters)
        {
            if (parameters == null) return null;

            foreach (var item in parameters)
            {
                if (item is BodyParameter)
                item.Name = item.Name.ToCamelCase();
            }
            return parameters;
        }

        
    }
}