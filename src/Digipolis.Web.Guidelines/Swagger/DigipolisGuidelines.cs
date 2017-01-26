﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using Digipolis.Errors;
using Digipolis.Web.Filters;
using Digipolis.Web.Guidelines.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.Swagger.Model;
using Swashbuckle.SwaggerGen.Generator;

namespace Digipolis.Web.Guidelines.Swagger
{
    public class DigipolisGuidelines : IResponseGuidelines
    {
        public virtual void Apply(Operation operation, OperationFilterContext context)
        {
            var actionAttributes = context.ApiDescription.GetActionAttributes().OfType<Attribute>();
            var controllerAttributes = context.ApiDescription.GetControllerAttributes().OfType<Attribute>();
            var attributes = actionAttributes.Union(controllerAttributes);

            UnauthorizedResponse(operation, context, attributes, actionAttributes);
            InternalServerErrorResponse(operation, context, attributes);
            BadRequestResponse(operation, context, attributes);
            NoContentResponse(operation, context, attributes);
            CreatedResponse(operation, context, attributes);
            OkResponse(operation, context, attributes);
            NotFoundResponse(operation, context, attributes);
            AddReturnSchemaToVersionEndpoint(operation, context);
        }

        public virtual void UnauthorizedResponse(Operation operation, OperationFilterContext context, IEnumerable<Attribute> attributes, IEnumerable<Attribute> actionaAtributes)
        {
            var allowsAnonymous = actionaAtributes.OfType<AllowAnonymousAttribute>().Any();
            if (operation.Responses.ContainsKey("401"))
            {
                foreach (var operationResponse in operation.Responses.Where(x => x.Key == "410"))
                {
                    operationResponse.Value.Description = "Unauthorized";
                }

                if(allowsAnonymous) operation.Responses.Remove("401");
                return;
            };
            if (!attributes.OfType<AuthorizeAttribute>().Any() || allowsAnonymous) return;
            operation.Responses.Add("401", new Response
            {
                Description = "Unauthorized",
                Schema = context.SchemaRegistry.GetOrRegister(typeof(Digipolis.Web.Guidelines.Models.Error))
            });
        }

        public virtual void BadRequestResponse(Operation operation, OperationFilterContext context, IEnumerable<Attribute> attributes)
        {
            if (operation.Responses.ContainsKey("400")) return;
            if (!attributes.Any(x=> x is ValidateModelStateAttribute || x is HttpPostAttribute || x is HttpPutAttribute || x is HttpPatchAttribute))
                return;

            operation.Responses.Add("400", new Response
            {
                Description = "Validation error",
                Schema = context.SchemaRegistry.GetOrRegister(typeof(Digipolis.Web.Guidelines.Models.Error))
            });
        }

        public virtual void InternalServerErrorResponse(Operation operation, OperationFilterContext context, IEnumerable<Attribute> attributes)
        {
            if (operation.Responses.ContainsKey("500")) return;
            operation.Responses.Add("500", new Response
            {
                Description = "Technical error",
                Schema = context.SchemaRegistry.GetOrRegister(typeof(Digipolis.Web.Guidelines.Models.Error)),
            });
        }

        public virtual void NoContentResponse(Operation operation, OperationFilterContext context, IEnumerable<Attribute> attributes)
        {
            if (!attributes.OfType<HttpDeleteAttribute>().Any()) return;
            operation.Responses.Remove("200");
            if (operation.Responses.ContainsKey("204")) return;

            operation.Responses.Add("204", new Response
            {
                Description = "Removed"
            });
        }

        public virtual void CreatedResponse(Operation operation, OperationFilterContext context, IEnumerable<Attribute> attributes)
        {
            if (!attributes.OfType<HttpPostAttribute>().Any()) return;
            if (!operation.Responses.ContainsKey("201")) return;
            var response = operation.Responses["201"];
            if(response.Description.Equals("Success", StringComparison.CurrentCultureIgnoreCase))
                response.Description = "Created";
        }

        public virtual void OkResponse(Operation operation, OperationFilterContext context, IEnumerable<object> attributes)
        {
            if (!operation.Responses.ContainsKey("200")) return;
            var response = operation.Responses["200"];
            if (response.Description.Equals("Success", StringComparison.CurrentCultureIgnoreCase))
                response.Description = "Ok";
        }

        public virtual void NotFoundResponse(Operation operation, OperationFilterContext context, IEnumerable<Attribute> attributes)
        {
            if (operation.Responses.ContainsKey("404"))
            {
                var response = operation.Responses["404"];
                if (response.Description.Equals("Client Error", StringComparison.CurrentCultureIgnoreCase))
                    response.Description = "Not found";
                return;
            }

            if (!context.ApiDescription.ParameterDescriptions.Any() || !attributes.Any(x => x is HttpGetAttribute || x is HttpPutAttribute || x is HttpPatchAttribute || x is HttpDeleteAttribute))
                return;

            operation.Responses.Add("404", new Response
            {
                Description = "Not found",
                Schema = context.SchemaRegistry.GetOrRegister(typeof(Digipolis.Web.Guidelines.Models.Error))
            });
        }

        public virtual void AddReturnSchemaToVersionEndpoint(Operation operation, OperationFilterContext context)
        {
            var operationId = context.ApiDescription.RelativePath.Contains("apiVersion") ? "ByApiVersionStatusVersionGet" : "StatusVersionGet";
            if (!operation.OperationId.Equals(operationId)) return;
            operation.Responses["200"].Schema = context.SchemaRegistry.GetOrRegister(typeof(VersionInfo));
            operation.Summary = "Get the version of the application";
            operation.Produces.Add("application/json");
        }
    }
}