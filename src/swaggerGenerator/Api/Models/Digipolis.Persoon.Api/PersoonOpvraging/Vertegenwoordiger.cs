using System;
using System.Runtime.Serialization;

namespace  Digipolis.Persoon.Api.Models.PersoonOpvraging
{
    
    public class Vertegenwoordiger : CodeTableBase
    {

        public String Inhoud { get; set; }

        public String Datum { get; set; }

    }
}