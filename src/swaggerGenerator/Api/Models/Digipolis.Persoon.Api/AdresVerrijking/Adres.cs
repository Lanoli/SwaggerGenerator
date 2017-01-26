using Newtonsoft.Json;
using System;
namespace Digipolis.Persoon.Api.Models.AdresVerrijking
{
    public class Adres
    {
        public int AdresId { get; set; }

        public int? LandCrsPandNr { get; set; }

        public int? GemeenteCrsPandNr { get; set; }

        public string DistrictCode { get; set; }

        public string DistrictNaam { get; set; }

        public int? StraatCrsPandNr { get; set; }

        public int? WooneenheidCrsPandNr { get; set; }

        public string LandNaam { get; set; }

        public int? LandNisCode { get; set; }

        public string GemeenteNaam { get; set; }

        public int? GemeenteNisCode { get; set; }

        public string Postnaam { get; set; }

        public string Postcode { get; set; }

        public string PostcodeRijksregisterNr { get; set; }

        public string StraatNaam { get; set; }

        public string StraatRijksregisterNr { get; set; }

        public int? HuisNr1 { get; set; }

        public string HuisNr2 { get; set; }

        public DateTime? LaatsteVerrijkingOp { get; set; }
        //public string BusNr { get; set; }
    }
}