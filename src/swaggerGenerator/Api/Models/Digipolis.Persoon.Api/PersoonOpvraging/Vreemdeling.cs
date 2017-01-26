using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace  Digipolis.Persoon.Api.Models.PersoonOpvraging
{
    
    public class Vreemdeling 
    {

        public List<AangegevenGeboorteDatum> AangegevenGeboorteDatums { get; set; }

        public List<DVZNummer> DVZNummers { get; set; }

        public List<BijzondereInformatie> BijzondereInformaties { get; set; }

        public List<VreemdelingCategorie> Categorieen { get; set; }

        public List<VreemdelingToestand> Toestanden { get; set; }

        public List<VerplichtePlaatsVanInschrijving> VerplichtePlaatsenVanInschrijving { get; set; }

        public List<VoorlopigInschrijvingsNummer> VoorlopigeInschrijvingsNummers { get; set; }

        public List<IdentiteitsDocument> IdentiteitsDocumenten { get; set; }

        public List<GekozenWoonplaats> GekozenWoonplaatsen { get; set; }

        public List<VreemdelingAlias> Aliassen { get; set; }

    }
}