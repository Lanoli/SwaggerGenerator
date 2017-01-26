using System.Runtime.Serialization;

namespace Digipolis.Persoon.Api.Models.PersoonSave
{
    
    public class VreemdelingAlias : Geldigheid
    {
        
        public string Ongestructureerd { get; set; }

        
        public string Code { get; set; }

        
        public string Omschrijving { get; set; }

        
        public string Nationaliteit { get; set; }

        
        public string NisCodeNationaliteit { get; set; }

        
        public string Naam { get; set; }

        
        public string GeboortePlaats { get; set; }

        
        public string DatumVerval { get; set; }
    }
}