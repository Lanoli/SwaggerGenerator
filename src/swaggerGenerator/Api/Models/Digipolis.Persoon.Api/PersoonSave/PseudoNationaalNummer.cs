using System.Runtime.Serialization;

namespace Digipolis.Persoon.Api.Models.PersoonSave
{
    
    public class PseudoNationaalNummer : Geldigheid
    {
        
        public string Ongestructureerd { get; set; }

        
        public string PseudoNationaalnummer { get; set; }
    }
}