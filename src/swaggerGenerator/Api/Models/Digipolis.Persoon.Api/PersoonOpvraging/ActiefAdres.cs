using System;
using System.Runtime.Serialization;

namespace  Digipolis.Persoon.Api.Models.PersoonOpvraging
{
    public class ActiefAdres
    {
        public string ActivatieDatum { get; set; }

        public AdresSoort Soort { get; set; }

        public GestructureerdAdres Gestructureerd { get; set; }

        public OngestructureerdAdres Ongestructureerd { get; set; }

    }
}