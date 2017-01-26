using System;
using System.Runtime.Serialization;

namespace  Digipolis.Persoon.Api.Models.PersoonOpvraging
{
    
    public class Naam : HistoriekBase 
    {

        public String Familienaam { get; set; }

        public String Voornaam1 { get; set; }

        public String Voornaam2 { get; set; }

        public String Voornaam3 { get; set; }

        public String VoornamenAndere { get; set; }

        public String Pseudoniem { get; set; }
    }
}