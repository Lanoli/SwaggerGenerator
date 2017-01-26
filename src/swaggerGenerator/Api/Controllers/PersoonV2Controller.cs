using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using swaggerGenerator.Api.Models;
using Swashbuckle.SwaggerGen.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace swaggerGenerator.Api.Controllers
{
    public class PersoonController
    {
        /// <summary>
        /// Persoonsgegevens bewaren
        /// </summary>
        /// <param name="persoon"></param>
        /// <returns></returns>
        [Authorize("Dummy")]
        [HttpPut] //PUT voor Upsert https://www.w3.org/Protocols/rfc2616/rfc2616-sec9.html#sec9.6
        [Route("/personen")]
        [Produces("application/json")]
        [Consumes("application/json")]
        [ProducesResponseType(typeof(Digipolis.Persoon.Api.Models.V2.PersoonPutResponse), 200)]
        [ProducesResponseType(typeof(Digipolis.Persoon.Api.Models.V2.PersoonPutResponse), 201)]
        [ProducesResponseType(typeof(Digipolis.Web.Guidelines.Models.Error), 400)]
        [ProducesResponseType(typeof(Digipolis.Web.Guidelines.Models.Error), 403)]
        [ProducesResponseType(typeof(Digipolis.Web.Guidelines.Models.Error), 500)]
        [SwaggerOperation(Tags = new[] { "personen" })]
        public async Task Save([FromBody]Digipolis.Persoon.Api.Models.V2.PersoonPutRequest persoon)
        {
        }

        /// <summary>
        /// Persoonsgegevens updaten adhv rijksregisterdossier (asynchrone verwerking)
        /// </summary>
        /// <param name="rijksregisterDossier"></param>
        /// <returns></returns>
        [Authorize("Dummy")]
        [HttpPost]
        [Route("/rijksregisterdossiers")]
        [Produces("application/json")]
        [Consumes("application/json")]
        [ProducesResponseType(typeof(Digipolis.Web.Guidelines.Models.Ok), 202)]
        [ProducesResponseType(typeof(Digipolis.Web.Guidelines.Models.Error), 400)]
        [ProducesResponseType(typeof(Digipolis.Web.Guidelines.Models.Error), 403)]
        [ProducesResponseType(typeof(Digipolis.Web.Guidelines.Models.Error), 500)]
        [SwaggerOperation(Tags = new[] {"rijksregisterdossiers"})]
        public async Task SaveRijksregisterDosier([FromBody]RijksregisterDossier rijksregisterDossier)
        {
        }


    }
}
