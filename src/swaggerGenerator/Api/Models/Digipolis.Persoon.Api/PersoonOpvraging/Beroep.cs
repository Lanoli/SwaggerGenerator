using System;
using System.Runtime.Serialization;

namespace  Digipolis.Persoon.Api.Models.PersoonOpvraging
{
    
    public class Beroep : CodeTableBase
    {

        public String SocialeGroepCode { get; set; }

        public String SocialeGroepOmschrijving { get; set; }

    }
}