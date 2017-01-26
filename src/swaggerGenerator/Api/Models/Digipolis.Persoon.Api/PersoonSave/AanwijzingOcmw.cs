using System.Runtime.Serialization;

namespace Digipolis.Persoon.Api.Models.PersoonSave
{
    
    public class AanwijzingOcmw : Geldigheid
    {
        
        public string Ongestructureerd { get; set; }

        
        public string CodeOpvangInitiatief { get; set; }

        
        public string OmschrijvingOpvangInitiatief { get; set; }

        
        public string NisCodePlaats { get; set; }

        
        public string OmschrijvingPlaats { get; set; }
    }
}