using System.Runtime.Serialization;

namespace Digipolis.Persoon.Api.Models.PersoonSave
{
    
    public class Nationaliteit : Geldigheid
    {
        
        public string NisCode { get; set; }

        
        public string Omschrijving { get; set; }
    }
}