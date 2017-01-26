namespace Digipolis.Persoon.Api.Models.PersoonOpvraging
{
    public class OngestructureerdAdres : HistoriekBase
    {
        public int? LandCrsNr { get; set; }
        public string LandNaam { get; set; }
        public string LandNisCode { get; set; }

        public string AdresTekst { get; set; }
    }
}
