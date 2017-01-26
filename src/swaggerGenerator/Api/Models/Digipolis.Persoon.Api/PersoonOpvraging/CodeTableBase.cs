using System;
using System.Runtime.Serialization;

namespace  Digipolis.Persoon.Api.Models.PersoonOpvraging
{
    
    public class CodeTableBase : HistoriekBase
    {
       
        public string Code { get; set; }

       
        public string Omschrijving { get; set; }

    }
}