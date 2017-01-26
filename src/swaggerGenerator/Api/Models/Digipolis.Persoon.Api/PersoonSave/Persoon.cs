using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Digipolis.Persoon.Api.Models.PersoonSave
{
    public class Persoon
    {
        
        public virtual string CreatieDatum { get; set; }

        
        public virtual string LaatsteBijwerkingsDatum { get; set; }

        
        public virtual string RijksregisterNr { get; set; }

        
        public virtual string BevolkingsNr { get; set; }

        
        public virtual string BronCode { get; set; }

        public List<AangegevenGeboorteDatum> AangegevenGeboorteDatumHistoriek { get; set; }

        public List<AangifteBuitenlandsAdres> AangifteBuitenlandsAdresHistoriek { get; set; }

        public List<AanvraagInschrijving> AanvraagInschrijvingHistoriek { get; set; }

        public List<AanwijzingOcmw> AanwijzingOcmwHistoriek { get; set; }

        public List<AdelTitel> AdelTitelHistoriek { get; set; }

        public List<AdresWijziging> AdresWijzigingHistoriek { get; set; }

        public List<Afwezigheid> AfwezigheidHistoriek { get; set; }

        public List<Afstamming> AfstammingHistoriek { get; set; }

        public List<ArbeidsKaart> ArbeidsKaartHistoriek { get; set; }

        public List<Beroep> BeroepHistoriek { get; set; }

        public List<BeroepsKaart> BeroepsKaartHistoriek { get; set; }

        public List<BuitenlandsAdres> BuitenlandsAdresHistoriek { get; set; }
        public List<BuitenlandsPostAdres> BuitenlandsPostAdresHistoriek { get; set; }
        public List<BurgerlijkeStaat> BurgerlijkeStaatHistoriek { get; set; }

        public List<Certificaat> CertificaatHistoriek { get; set; }

        public List<Geboorte> GeboorteHistoriek { get; set; }

        public List<GemeenteVanVerblijf> GemeenteVanVerblijfHistoriek { get; set; }

        public List<Geslacht> GeslachtHistoriek { get; set; }

        public List<GezinsLid> GezinsLidHistoriek { get; set; }

        public List<IdentiteitsBewijs> IdentiteitsBewijsHistoriek { get; set; }
        public List<Naam> NaamHistoriek { get; set; }

        public List<Nationaliteit> NationaliteitHistoriek { get; set; }

        public List<NietMededeelbaarAdres> NietMededeelbaarAdresHistoriek { get; set; }

        public List<Overlijden> OverlijdenHistoriek { get; set; }
        public List<OfficieelAdres> OfficieelAdresHistoriek { get; set; }
        public List<Paspoort> PaspoortHistoriek { get; set; }
        public List<PseudoNationaalNummer> PseudoNationaalNummerHistoriek { get; set; }

        public List<Pseudoniem> PseudoniemHistoriek { get; set; }

        public List<ReferentieAdres> ReferentieAdresHistoriek { get; set; }

        public List<Register> RegisterHistoriek { get; set; }

        public List<TijdelijkeAfwezigheid> TijdelijkeAfwezigheidHistoriek { get; set; }

        public List<Vertegenwoordiging> VertegenwoordigingHistoriek { get; set; }

        public List<Vertegenwoordiger> VertegenwoordigerHistoriek { get; set; }

        public List<VreemdelingAlias> VreemdelingAliasHistoriek { get; set; }

        public List<VreemdelingCategorie> VreemdelingCategorieHistoriek { get; set; }

        public List<VreemdelingGekozenWoonplaats> VreemdelingGekozenWoonplaatsHistoriek { get; set; }

        public List<VreemdelingIdentiteitsDocument> VreemdelingIdentiteitsDocumentHistoriek { get; set; }

        public List<VreemdelingOpgegevenAdres> VreemdelingOpgegevenAdresHistoriek { get; set; }

        public List<VreemdelingOvNummer> VreemdelingOvNummerHistoriek { get; set; }

        public List<VreemdelingRedenenVanVerblijf> VreemdelingRedenenVanVerblijfHistoriek { get; set; }

        public List<VreemdelingToestand> VreemdelingToestandHistoriek { get; set; }

        public List<WettelijkeSamenwoning> WettelijkeSamenwoningHistoriek { get; set; }

        public List<WettelijkeWoonplaats> WettelijkeWoonplaatsHistoriek { get; set; }
    }

}
