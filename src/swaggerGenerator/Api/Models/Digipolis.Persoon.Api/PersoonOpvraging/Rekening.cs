using System;
using System.Runtime.Serialization;

namespace  Digipolis.Persoon.Api.Models.PersoonOpvraging
{
    
    public class Rekening 
    {

        public String RekeningNummer { get; set; }

        public String IBANRekeningNummer { get; set; }

        public String BICCode { get; set; }

        public String StatusCode { get; set; }

        public String StatusOmschrijving { get; set; }

    }
}