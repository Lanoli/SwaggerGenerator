using System;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace  Digipolis.Persoon.Api.Models.Rekening
{
    public class AddRekeningCriteria
    {                  
        public string IBANRekeningNr { get; set; }

        public string BICCode { get; set; }

        public int LandCrsNr { get; set; }
    }
}