using System.Runtime.Serialization;

namespace Digipolis.Persoon.Api.Models.PersoonSave
{
    
    public class Afwezigheid : Geldigheid
    {
        
        public string BeslissingSoort { get; set; }

        
        public string BeslissingOmschrijving { get; set; }

        
        public string ExtraInformatie { get; set; }
    }
}