using System;
using System.Runtime.Serialization;

namespace  Digipolis.Persoon.Api.Models.PersoonOpvraging
{
    
    public class Bron 
    {

        public String Code { get; set; }

        public String Omschrijving { get; set; }

        public Boolean IsAuthentiek { get; set; }

    }
}