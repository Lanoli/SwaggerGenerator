using System.Runtime.Serialization;

namespace Digipolis.Persoon.Api.Models.PersoonOpvraging
{
    
    public class Rechtbank: HistoriekBase
    {
        public string Code { get; set; }

        public string Naam { get; set; }

        public string RijksregisterNaam { get; set; }

        public Plaats Plaats { get; set; }

        public Land Land { get; set; }
    }
}