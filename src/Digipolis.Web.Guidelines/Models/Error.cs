using System;
using System.Collections.Generic;
using System.Linq;


namespace Digipolis.Web.Guidelines.Models
{
    public class Error
    {
        /// <summary>
        /// Een unieke identifier om de foutboodschap terug te vinden in log bestanden.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Een foutcode die 1 op 1 mapt met het Type en waartegen ontwikkelaars kunnen programmeren.
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Een URI referentie (absoluut of relatief) [RFC3986] dewelke het probleem type identificeert. 
        /// Indien verwezen wordt naar deze URI dient human-readable (HTML) documentatie voor het probleem te worden weergegeven.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Een korte, human-readable omschrijving van het probleem. 
        /// De title die hier wordt weergegeven mapt 1-op-1 met een omschrijving van het hierboven vernoemde Type.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// de HTTP status code. De reden van vermelding in het error object is omdat eventuele intermediaries zoals gateways de HTTP status code steeds kunnen wijzigen.
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// Meer specifieke human-readable detail informatie die specifiek is voor deze instantie van het probleem.
        /// </summary>
        public string Detail { get; set; }

        /// <summary>
        ///  Een URI referentie (absoluut of relatief) dewelke de instantie van het probleem identificeert unieke identifier om de foutboodschap terug te vinden in log bestanden.
        /// </summary>
        public string Instance { get; set; }

        /// <summary>
        /// Extra parameters die nuttig zijn voor de API consumer om het probleem te kunnen begrijpen.
        /// </summary>
        public Dictionary<string, string> Parameters { get; set; }

        public Error()
        {
            Parameters = new Dictionary<string, string>();
        }
    }
}