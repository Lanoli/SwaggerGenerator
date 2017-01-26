using System;
using System.Runtime.Serialization;

namespace  Digipolis.Persoon.Api.Models.PersoonOpvraging
{
    
    public class KaartBase : CodeTableBase
    {

        public String Nummer { get; set; }

        public String UitreikingsDatum { get; set; }

        public String VervalDatum { get; set; }

    }
}