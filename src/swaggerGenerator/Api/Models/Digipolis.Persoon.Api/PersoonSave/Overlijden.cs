using System.Runtime.Serialization;

namespace Digipolis.Persoon.Api.Models.PersoonSave
{
    
    public class Overlijden : Geldigheid
    {
        
        public string Datum { get; set; }

        
        public string AkteNr { get; set; }

        
        public Plaats Plaats { get; set; }
    }
}
