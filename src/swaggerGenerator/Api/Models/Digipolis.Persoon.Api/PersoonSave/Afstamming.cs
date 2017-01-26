using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Digipolis.Persoon.Api.Models.PersoonSave
{
    
    public class Afstamming : Geldigheid
    {
        
        public string AkteNummer { get; set; }
        
        
        public string CodeAfstammingsWijze { get; set; }

        
        public string OmschrijvingAfstammingsWijze { get; set; }

        
        public string Commentaar { get; set; }

        
        public string MoederFamilienaam { get; set; }

        
        public string MoederRrNr { get; set; }

        
        public string MoederVoornaam1 { get; set; }

        
        public string MoederVoornaam2 { get; set; }

        
        public string MoederVoornaam3 { get; set; }

        public string MoederVoornaamAndere { get; set; }

        public string NisCode { get; set; }

        
        public string Plaats { get; set; }

        
        public string VaderFamilienaam { get; set; }

        
        public string VaderRrNr { get; set; }

        
        public string VaderVoornaam1 { get; set; }

        
        public string VaderVoornaam2 { get; set; }

        
        public string VaderVoornaam3 { get; set; }

        public string VaderVoornaamAndere { get; set; }

        //[IgnoreDataMember]
        //public string MoederVoornamen
        //{
        //    get { return string.Format("{0} {1} {2}", MoederVoornaam1, MoederVoornaam2, MoederVoornaam3).Trim(); }
        //}

        //[IgnoreDataMember]
        //public string VaderVoornamen
        //{
        //    get { return string.Format("{0} {1} {2}", VaderVoornaam1, VaderVoornaam2, VaderVoornaam3).Trim(); }
        //}
    }
}