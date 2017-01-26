using System.Runtime.Serialization;

namespace Digipolis.Persoon.Api.Models.PersoonSave
{
    
    public class GezinsLid : Geldigheid
    {
        
        public string Code { get; set; }

        
        public string Omschrijving { get; set; }
        
        
        public Betrokkene Betrokkene { get; set; }

        
        public bool IsReferentiePersoon { get; set; }
    }
}