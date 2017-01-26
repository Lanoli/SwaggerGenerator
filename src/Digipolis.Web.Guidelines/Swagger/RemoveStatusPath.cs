using Swashbuckle.SwaggerGen.Generator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Swashbuckle.Swagger.Model;

namespace Digipolis.Web.Guidelines.Swagger
{
    public class RemoveStatusPathDocumentFilter : IDocumentFilter
    {
        public void Apply(SwaggerDocument swaggerDoc, DocumentFilterContext context)
        {
            swaggerDoc.Paths = swaggerDoc.Paths.Where(x => x.Key != "/status/version")
                .ToDictionary(x => x.Key, x => x.Value);
        }
    }
}
