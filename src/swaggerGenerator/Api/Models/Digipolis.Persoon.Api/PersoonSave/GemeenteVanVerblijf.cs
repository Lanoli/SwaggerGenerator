using System.Runtime.Serialization;

namespace Digipolis.Persoon.Api.Models.PersoonSave
{
    
    public class GemeenteVanVerblijf : Geldigheid
    {
        
        public string Ongestructureerd { get; set; }

        
        public GemeentePost Gemeente { get; set; }

        
        public Land Land { get; set; }

        
        public string Omschrijving { get; set; }

        
        public string Soort { get; set; }
    }
}