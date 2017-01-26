using System;
using System.Runtime.Serialization;

namespace Digipolis.Persoon.Api.Models.PersoonSave
{
    
    public class Naam : Geldigheid
    {
        
        public String Familienaam { get; set; }

        
        public string Voornaam1 { get; set; }

        
        public string Voornaam2 { get; set; }

        
        public string Voornaam3 { get; set; }

        
        public string VoornamenAndere { get; set; }
    }

}
