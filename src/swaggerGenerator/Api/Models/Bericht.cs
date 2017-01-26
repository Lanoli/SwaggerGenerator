using System;
using System.Runtime.Serialization;

namespace  Digipolis.Persoon.Api.Models
{
    
    public class Bericht 
    {
        public Bericht()
        { }

        public Bericht(BerichtSoort soort, String tekst, String code = "")
        {
            Soort = soort;
            Tekst = tekst;
        }

        public BerichtSoort Soort { get; set; }

        public String Tekst { get; set; }

        public String Code { get; set; }

    }
}