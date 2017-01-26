using System.Runtime.Serialization;

namespace Digipolis.Persoon.Api.Models.PersoonSave
{
    
    public class Rechtbank
    {
        
        public string Code { get; set; }

        
        public string Naam { get; set; }

        
        public Plaats Plaats { get; set; }
    }
}