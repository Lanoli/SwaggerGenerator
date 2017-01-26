using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace  Digipolis.Persoon.Api.Models.PersoonOpvraging
{
    
    public class EigenBeheerAdressen 
    {

        public List<Adres> GevalideerdBuitenlandsAdressen { get; set; }

        public List<Adres> VerblijfsAdressen { get; set; }

        public List<Adres> VerzendAdressen { get; set; }

    }
}