using System.Runtime.Serialization;

namespace Digipolis.Persoon.Api.Models.PersoonSave
{
    
    public class AangifteBuitenlandsAdres : Geldigheid
    {
        public Land Land { get; set; }
        
        public string Ongestructureerd { get; set; }
    }
}