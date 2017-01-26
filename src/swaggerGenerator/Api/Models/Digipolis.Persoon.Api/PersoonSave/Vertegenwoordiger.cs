using System.Runtime.Serialization;

namespace Digipolis.Persoon.Api.Models.PersoonSave
{
    
    public class Vertegenwoordiger : Geldigheid
    {
        
        public string Omschrijving { get; set; }

        
        public string ToestandCode { get; set; }

        
        public string RechtvaardigingCode { get; set; }
    }
}