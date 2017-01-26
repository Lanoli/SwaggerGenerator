using System.Runtime.Serialization;

namespace Digipolis.Persoon.Api.Models.PersoonSave
{
    
    public class AanvraagInschrijving : Geldigheid
    {
        public string Ongestructureerd { get; set; }
        
        public string NisCode { get; set; }
    }
}