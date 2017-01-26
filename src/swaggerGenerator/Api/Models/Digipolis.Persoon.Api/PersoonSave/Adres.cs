using System.Runtime.Serialization;

namespace Digipolis.Persoon.Api.Models.PersoonSave
{
    
    public class Adres
    {
        
        public int? AdresCrsNr { get; set; }

        
        public int? LandNisCode { get; set; }

        
        public int? GemeenteNisCode { get; set; }

        
        public string StraatRijksregisterNr { get; set; }

        
        public string LandNaam { get; set; }

        
        public string GemeenteNaam { get; set; }

        
        public string DistrictNaam { get; set; }

        
        public string PostNaam { get; set; }

        
        public string StraatNaam { get; set; }

        
        public string Postcode { get; set; }

        
        public string HuisNr1 { get; set; }

        
        public string SubAdres { get; set; }
    }
}
