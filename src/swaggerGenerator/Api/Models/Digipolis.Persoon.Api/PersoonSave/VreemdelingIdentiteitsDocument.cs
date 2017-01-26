using System.Runtime.Serialization;

namespace Digipolis.Persoon.Api.Models.PersoonSave
{
    
    public class VreemdelingIdentiteitsDocument : Geldigheid
    {
        
        public string Ongestructureerd { get; set; }

        
        public string Code { get; set; }

        
        public string Omschrijving { get; set; }
    }
}