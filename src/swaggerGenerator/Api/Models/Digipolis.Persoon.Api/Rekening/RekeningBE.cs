using System;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace  Digipolis.Persoon.Api.Models.Rekening
{
    public class RekeningBE
    {
        public string CrsPersoonNr { get; set; }

        public string IBANRekeningNr { get; set; }

        public string BICCode { get; set; }
    }
}