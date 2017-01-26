using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace swaggerGenerator.Api.Models
{
    public class RijksregisterDossier
    {
        /// <summary>
        /// Het base64 encoded rijksregisterdossier (opvraging 25)
        /// </summary>
        [Required]
        public string RijksregisterDossierOpvraging25 { get; set; }

        /// <summary>
        /// Het base64 encoded rijksregisterdossier (opvraging 79)
        /// </summary>
        public string RijksregisterDossierOpvraging79 { get; set; }
    }

}
