using System;
using System.Runtime.Serialization;

namespace  Digipolis.Persoon.Api.Models.PersoonOpvraging
{
    
    public class Straat 
    {

        public String Naam { get; set; }

        public String CrsNummer { get; set; }

        public Gemeente Gemeente { get; set; }

        public String RijksregisterNummer { get; set; }

    }
}