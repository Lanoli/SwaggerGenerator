using System.Runtime.Serialization;

namespace Digipolis.Persoon.Api.Models.PersoonSave
{
    
    public class VreemdelingRedenenVanVerblijf : Geldigheid
    {
        
        public string Ongestructureerd { get; set; }

        
        public string CodeBestemmeling { get; set; }

        
        public string CodeVerblijfsMotief { get; set; }

        
        public string OmschrijvingBestemmeling { get; set; }

        
        public string OmschrijvingVerblijfsMotief { get; set; }

        
        public string RijksregisterNummerGezinsHereniging { get; set; }

        
        public string Toelichting { get; set; }
    }
}