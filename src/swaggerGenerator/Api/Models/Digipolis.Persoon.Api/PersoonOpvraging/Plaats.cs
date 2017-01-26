using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Digipolis.Persoon.Api.Models.PersoonOpvraging
{
    public partial class Plaats : HistoriekBase
    {
        public string Naam { get; set; }

        public int? GemPostCrsNr { get; set; }

        public string NisCode { get; set; }
        public string PostCode { get; set; }
        public string PostNaam { get; set; }

        public Land Land { get; set; }
    }
}