using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;


namespace Digipolis.Persoon.Api.Models.V2
{
    public class PersoonPutRequest : Api.Models.PersoonSave.Persoon
    {
        /// <summary>
        /// Code van de bron van de persoon. (bv. RIJK = rijksregister, HERA)
        /// </summary>
        [Required]
        public override string BronCode { get; set; }

        /// <summary>
        /// Creatiedatum van de persoon in het bronsysteem.
        /// </summary>
        public override string CreatieDatum { get; set; }

        /// <summary>
        /// Laatste bijwerkingsdatum van de persoon in het bronsysteem.
        /// </summary>
        public override string LaatsteBijwerkingsDatum { get; set; }

        /// <summary>
        /// Rijksregisternummer van de persoon. Dit is de unieke sleutel van een persoon in het rijksregister
        /// Dit bestaat uit 11 cijfers (met modulo 97 controle) zonder scheidingstekens
        /// Indien er geen rijksregisternummer wordt ingevuld, moet bevolkingsnummer ingevuld zijn
        /// </summary>
        public override string RijksregisterNr { get; set; }

        /// <summary>
        /// Bevolkingsnummer van der persoon. Dit is de unieke sleutel van een persoon in de bevolkingstoepassing (HERA, HOSPES)
        /// Indien er geen bevolkingsnummer wordt ingevuld, moet de rijksregisternummer ingevuld zijn
        /// </summary>
        public override string BevolkingsNr { get; set; }
       

    }
}