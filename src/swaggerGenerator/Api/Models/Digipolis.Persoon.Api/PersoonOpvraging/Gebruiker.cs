using System;
using System.Runtime.Serialization;

namespace  Digipolis.Persoon.Api.Models.PersoonOpvraging
{
    
    public class Gebruiker  
    {

        public String RijksregisterNr { get; set; }

        public String Account { get; set; }

        public String Familienaam { get; set; }

        public String Voornamen { get; set; }

        public String ToepassingsCode { get; set; }

    }
}