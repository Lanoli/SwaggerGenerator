using System;
using System.Runtime.Serialization;

namespace  Digipolis.Persoon.Api.Models.PersoonOpvraging
{
    
    public class GemeenteVanVerblijf : CodeTableBase
    {
        public Boolean IsGestructureerd { get; set; }
        public String Ongestructureerd { get; set; }

        public String GemeenteNaam { get; set; }
        public String GemeenteNisCode { get; set; }

        public Land Land { get; set; }
    }
}