using System;
using System.Runtime.Serialization;

namespace  Digipolis.Persoon.Api.Models.PersoonOpvraging
{
    
    public class Overlijden : HistoriekBase 
    {

        public String Datum { get; set; }

        public String AkteNummer { get; set; }

        public Plaats OverlijdensPlaats { get; set; }

        public District OverlijdensDistrict { get; set; }

        public String Ongestructureerd { get; set; }

        public Boolean IsGestructureerd { get; set; }

    }
}