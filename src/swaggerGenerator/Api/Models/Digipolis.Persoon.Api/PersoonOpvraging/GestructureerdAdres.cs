using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digipolis.Persoon.Api.Models.PersoonOpvraging
{
    public class GestructureerdAdres : HistoriekBase
    {
        public int? AdresCrsNr { get; set; }
        public int? StraatCrsNr { get; set; }
        public int? GemPostCrsNr { get; set; }
        public int? LandCrsNr { get; set; }

        public string StraatNaam { get; set; }
        public string StraatRijksregisterNummer { get; set; }

        public string GemeenteNaam { get; set; }
        public string GemeenteNisCode { get; set; }

        public string LandNaam { get; set; }
        public string LandNisCode { get; set; }

        public string PostNaam { get; set; }
        public string Postcode { get; set; }

        public string HuisNr { get; set; }
        public string Suffix { get; set; }
    }
}
