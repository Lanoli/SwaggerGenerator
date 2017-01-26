using System.Runtime.Serialization;

namespace Digipolis.Persoon.Api.Models.PersoonSave
{
    
    public class VreemdelingToestand : Geldigheid
    {
        
        public string Ongestructureerd { get; set; }

        
        public string CodeBeroep { get; set; }

        
        public string CodeKennisgeving1 { get; set; }

        
        public string CodeKennisgeving2 { get; set; }

        
        public string CodeKennisgeving3 { get; set; }

        
        public string CodeOpenClose { get; set; }

        
        public string CodeOrganisme { get; set; }

        
        public string CodeOrganismeOrigine { get; set; }

        
        public string NisCodeAsielAanvraag { get; set; }

        
        public string OmschrijvingBeroep { get; set; }

        
        public string OmschrijvingKennisgeving1 { get; set; }

        
        public string OmschrijvingKennisgeving2 { get; set; }

        
        public string OmschrijvingKennisgeving3 { get; set; }

        
        public string OmschrijvingOpenClose { get; set; }

        
        public string OmschrijvingOrganisme { get; set; }

        
        public string OmschrijvingOrganismeOrigine { get; set; }

        
        public string PlaatsAsielAanvraag { get; set; }
    }
}