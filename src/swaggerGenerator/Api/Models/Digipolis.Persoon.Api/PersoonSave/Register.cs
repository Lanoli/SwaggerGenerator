using System.Runtime.Serialization;

namespace Digipolis.Persoon.Api.Models.PersoonSave
{
    
    public class Register : Geldigheid
    {
        
        public string Soort { get; set; }

        
        public string Omschrijving { get; set; }
    }
}