using System.Runtime.Serialization;

namespace Digipolis.Persoon.Api.Models.PersoonSave
{
    
    public class BuitenlandsPostAdres : Geldigheid
    {
        
        public Land Land { get; set; }

        
        public string Ongestructureerd { get; set; }

        
        public int HernummeringNummer { get; set; }
        //Buitenlandspost adres is deels gestructureerd.
        //
        //public Adres Adres { get; set; }
    }
}