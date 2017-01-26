using System;
using System.Runtime.Serialization;

namespace Digipolis.Persoon.Api.Models.PersoonOpvraging
{
    
    public class Land
    {

        public String Naam { get; set; }

        public String CrsNummer { get; set; }

        public String NisCode { get; set; }

        public Iso3166_1 IsoCode { get; set; }

    }

    
    public class Iso3166_1
    {
        public string TweeLetterCode { get; set; }

        public string DrieLetterCode { get; set; }

        public string DrieCijfercode { get; set; }
    }
}