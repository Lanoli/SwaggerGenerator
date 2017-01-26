using System.Runtime.Serialization;

namespace Digipolis.Persoon.Api.Models.PersoonSave
{
    
    public class Beroep : Geldigheid
    {
        
        public string Code { get; set; }

        
        public string Omschrijving { get; set; }

        
        public string SocialeGroepCode { get; set; }

        
        public string SocialeGroepOmschrijving { get; set; }
    }
}