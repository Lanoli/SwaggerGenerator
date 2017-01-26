using System.Runtime.Serialization;

namespace Digipolis.Persoon.Api.Models.PersoonSave
{
    
    public class Relatie
    {
        
        public string Code { get; set; }

        
        public string Omschrijving { get; set; }

        
        public Betrokkene Betrokkene { get; set; }

        
        public string GeldigVan { get; set; }

        
        public string GeldigTot { get; set; }
    }
}