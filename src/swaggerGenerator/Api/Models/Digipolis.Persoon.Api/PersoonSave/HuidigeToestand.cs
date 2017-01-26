using System.Runtime.Serialization;

namespace Digipolis.Persoon.Api.Models.PersoonSave
{
    
    public class HuidigeToestand : Geldigheid
    {
        
        public string Code { get; set; }

        
        public string Omschrijving { get; set; }
    }
}