using System;
using System.Runtime.Serialization;

namespace Digipolis.Persoon.Api.Models.PersoonOpvraging
{

    public class Gezinslid : HistoriekBase
    {
        public String RijksregisterNummer { get; set; }

        public String Familienaam { get; set; }

        public String Voornamen { get; set; }

        public String RelatieCode { get; set; }

        public String RelatieOmschrijving { get; set; }
    }
}