using System.Runtime.Serialization;

namespace Digipolis.Persoon.Api.Models.PersoonSave
{
    
    public class WettelijkeSamenwoning : Geldigheid
    {
        
        public Partner Partner { get; set; }

        
        public string Soort { get; set; }

        
        public string Omschrijving { get; set; }

        
        public string Reden { get; set; }

        
        public Plaats RegistratiePlaats { get; set; }

        
        public string RegistratieDatum { get; set; }

        
        public Plaats PlaatsBetekening { get; set; }

        
        public string DatumBetekening { get; set; }

        
        public Plaats PlaatsGebeurtenis { get; set; }
    }
}