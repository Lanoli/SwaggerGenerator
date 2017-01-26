using System.Runtime.Serialization;

namespace Digipolis.Persoon.Api.Models.PersoonSave
{
    public class AangegevenGeboorteDatum : Geldigheid
    {
        
        public string GeboorteDatum { get; set; }

        
        public string CodeBewijs { get; set; }

        
        public string OmschrijvingBewijs { get; set; }
   }
}
