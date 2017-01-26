using System;
using System.Runtime.Serialization;

namespace  Digipolis.Persoon.Api.Models.PersoonOpvraging
{
    
    public class Audit  
    {

        public DateTime CreatieDatum { get; set; }

        public DateTime? WijzigingsDatum { get; set; }

        public Gebruiker CreatieGebruiker { get; set; }

        public Gebruiker WijzigingsGebruiker { get; set; }

        public DateTime? ImportDatum { get; set; }

    }
}