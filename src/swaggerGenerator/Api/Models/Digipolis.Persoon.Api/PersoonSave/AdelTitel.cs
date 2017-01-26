using System.Runtime.Serialization;

namespace Digipolis.Persoon.Api.Models.PersoonSave
{
    
    public class AdelTitel : Geldigheid
    {
        
        public string Code { get; set; }

        
        public string Omschrijving { get; set; }
    }
}