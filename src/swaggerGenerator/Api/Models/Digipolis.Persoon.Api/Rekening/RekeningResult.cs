using System;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace  Digipolis.Persoon.Api.Models.Rekening
{
    public class RekeningResult : ResultaatBase
    {
        public int RekeningId { get; set; }
    }
}