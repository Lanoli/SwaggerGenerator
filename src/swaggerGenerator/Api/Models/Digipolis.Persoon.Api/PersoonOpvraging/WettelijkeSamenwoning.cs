using System;
using System.Runtime.Serialization;

namespace  Digipolis.Persoon.Api.Models.PersoonOpvraging
{
    
    public class WettelijkeSamenwoning : CodeTableBase 
    {

        public String Datum {get; set;} 
        public String Reden {get; set;} 
        public Betrokkene Partner {get; set;} 
        public Plaats RegistratiePlaats {get; set;} 
        public String RegistratieDatum {get; set;}
        public Plaats PlaatsGebeurtenis { get; set; }
        public Plaats PlaatsBetekening { get; set; } 
        public String DatumBetekening {get; set;} 

    }
}