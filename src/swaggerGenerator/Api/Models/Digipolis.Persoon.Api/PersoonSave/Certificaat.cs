using System.Runtime.Serialization;

namespace Digipolis.Persoon.Api.Models.PersoonSave
{
    
    public class Certificaat : Geldigheid
    {
        
        public string Nummer { get; set; }

        
        public string Certificaat1Code { get; set; }

        
        public string Certificaat1Omschrijving { get; set; }

        
        public string Certificaat2Code { get; set; }

        
        public string Certificaat2Omschrijving { get; set; }
    }
}