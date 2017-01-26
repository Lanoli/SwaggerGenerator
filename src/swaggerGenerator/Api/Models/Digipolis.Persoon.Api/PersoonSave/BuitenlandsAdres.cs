using System.Runtime.Serialization;

namespace Digipolis.Persoon.Api.Models.PersoonSave
{
    
    public class BuitenlandsAdres : Geldigheid
    {
        
        public Land Land { get; set; }

        
        public string Ongestructureerd { get; set; }

        
        public int HernummeringNummer { get; set; }
        //Deels ongestructureerd, enkel land is gestructureerd.
        //
        //public Adres Adres { get; set; }
    }
}