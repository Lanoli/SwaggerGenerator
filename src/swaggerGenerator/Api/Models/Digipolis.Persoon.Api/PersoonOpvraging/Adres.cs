using System;
using System.Runtime.Serialization;

namespace  Digipolis.Persoon.Api.Models.PersoonOpvraging
{
    
    public class Adres : HistoriekBase 
    {

        public Straat Straat { get; set; }

        public WoonEenheid WoonEenheid { get; set; }

        public String Ongestructureerd { get; set; }

        public Boolean IsGestructureerd { get; set; }

    }
}