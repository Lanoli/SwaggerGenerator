using System.Runtime.Serialization;

namespace Digipolis.Persoon.Api.Models.PersoonSave
{
    
    public class ArbeidsKaart : Geldigheid
    {
        
        public string Nummer { get; set; }

        
        public string Soort { get; set; }

        
        public string Omschrijving { get; set; }

        
        public string VervalDatum { get; set; }
    }
}