using System;
using System.Runtime.Serialization;

namespace  Digipolis.Persoon.Api.Models.PersoonOpvraging
{
    
    public class BurgerlijkeStaat : HistoriekBase
    {
        public String Datum {get; set;}
        public String Code {get; set;}
        public String Omschrijving {get; set;}
        public String AkteNummer {get; set;}
        public Betrokkene Partner {get; set;} 
        public String GebeurtenisDatum {get; set;} 
        public Plaats GebeurtenisPlaats {get; set;} 
        public District GebeurtenisDistrict {get; set;} 
        public String UitspraakDatum {get; set;} 
        public Rechtbank Rechtbank {get; set;} 
        public String OverschrijvingsDatum {get; set;}
        public Plaats OverschrijvingsPlaats { get; set; } 
        public District OverschrijvingsDistrict {get; set;} 
        public String AanvullendRegister {get; set;} 
    }
}