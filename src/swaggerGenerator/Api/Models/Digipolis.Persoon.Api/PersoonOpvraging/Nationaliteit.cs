using System;
using System.Runtime.Serialization;

namespace  Digipolis.Persoon.Api.Models.PersoonOpvraging
{
    
    public class Nationaliteit : HistoriekBase
    {
        public string Datum { get; set; }

        public string Naam { get; set; }

        public string NisCode { get; set; }
    }
}