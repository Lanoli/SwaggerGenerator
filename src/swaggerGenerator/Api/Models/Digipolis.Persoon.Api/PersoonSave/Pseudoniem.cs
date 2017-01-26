using System.Runtime.Serialization;

namespace Digipolis.Persoon.Api.Models.PersoonSave
{
    
    public class Pseudoniem : Geldigheid
    {
        
        public string Naam { get; set; }

        
        public bool IsVerklaardeNaam { get; set; }
    }
}