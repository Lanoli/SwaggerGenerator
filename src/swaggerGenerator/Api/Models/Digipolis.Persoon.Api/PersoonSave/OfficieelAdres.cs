using System.Runtime.Serialization;

namespace Digipolis.Persoon.Api.Models.PersoonSave
{
    
    public class OfficieelAdres : Geldigheid
    {
        
        public int HernummeringNummer { get; set; }

        
        public Adres Adres { get; set; }
    }
}