using System;
using System.Runtime.Serialization;

namespace  Digipolis.Persoon.Api.Models.PersoonOpvraging
{
    
    public class Gemeente 
    {

        public String Naam { get; set; }

        public String PostNaam { get; set; }

        public String PostCode { get; set; }

        public String NisCode { get; set; }

        public String CrsNummer { get; set; }

        public Land Land { get; set; }

    }
}