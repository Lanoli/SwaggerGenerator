using System.Runtime.Serialization;

namespace Digipolis.Persoon.Api.Models.PersoonSave
{
    
    public class IdentiteitsBewijs : Geldigheid
    {
        
        public string Nummer { get; set; }

        
        public string Soort { get; set; }

        
        public string Omschrijving { get; set; }
        
        
        public int DuplikaatNr { get; set; }

        
        public string VervalDatum { get; set; }
    }
}