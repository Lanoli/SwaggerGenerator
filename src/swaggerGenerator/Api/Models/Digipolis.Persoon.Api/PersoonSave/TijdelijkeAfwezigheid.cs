using System.Runtime.Serialization;

namespace Digipolis.Persoon.Api.Models.PersoonSave
{
    
    public class TijdelijkeAfwezigheid : Geldigheid
    {
        
        public string Plaats { get; set; }

        
        public string Omschrijving { get; set; }

        
        public string Soort { get; set; }
    }
}