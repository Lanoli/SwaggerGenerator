using System;
using System.Runtime.Serialization;

namespace  Digipolis.Persoon.Api.Models.PersoonOpvraging
{
    
    public class Geboorte : HistoriekBase
    {
        public String Datum { get; set; }
        public String AkteNummer { get; set; } 
        public Plaats GeboortePlaats {get; set;}
        public District GeboorteDistrict { get; set; }
        //public String Ongestructureerd { get; set; }
        //public Boolean IsGestructureerd { get; set; } 
    }
}