using System.Runtime.Serialization;

namespace Digipolis.Persoon.Api.Models.PersoonSave
{
    
    public class VreemdelingOvNummer : Geldigheid
    {
        
        public string DvzNummer { get; set; }

        
        public string Ongestructureerd { get; set; }
    }
}