using System;
using System.Collections.Generic;
using Digipolis.Persoon.Api;

namespace  Digipolis.Persoon.Api.Models.PersoonOpvraging
{
    public class Persoon
    {

        public String CrsNummer { get; set; }

        public String RijksregisterNummer { get; set; }

        public String BevolkingsNummer { get; set; }

        public List<String> VorigeCrsNummers { get; set; }

        public Geslacht Geslacht { get; set; }

        public List<Adeltitel> Adeltitels { get; set; }

        public List<Afwezigheid> Afwezigheden { get; set; }

        public List<Afstamming> Afstammingen { get; set; }

        public List<ArbeidsKaart> ArbeidsKaarten { get; set; }

        public List<Beroep> Beroepen { get; set; }

        public List<BeroepsKaart> BeroepsKaarten { get; set; }

        public List<BurgerlijkeStaat> BurgerlijkeStaten { get; set; }

        public List<Certificaat> Certificaten { get; set; }

        public List<ContactGegeven> ContactGegevens { get; set; }

        public List<Geboorte> Geboortes { get; set; }

        public List<GemeenteVanVerblijf> GemeentesVanVerblijf { get; set; }

        //Gezin via aparte resource.
        //public List<Gezinslid> GezinsLeden { get; set; }

        public List<IdentiteitsBewijs> IdentiteitsBewijzen { get; set; }

        public List<Naam> Namen { get; set; }

        public List<Nationaliteit> Nationaliteiten { get; set; }

        public List<Overlijden> Overlijdens { get; set; }

        public List<Rekening> Rekeningen { get; set; }

        public List<Paspoort> Paspoorten { get; set; }

        public List<Register> Registers { get; set; }

        public List<TijdelijkeAfwezigheid> TijdelijkeAfwezigheden { get; set; }

        public HuidigeToestand HuidigeToestand { get; set; }

        public List<Vertegenwoordiger> Vertegenwoordigers { get; set; }

        public List<Vertegenwoordiging> Vertegenwoordigingen { get; set; }

        public Vreemdeling Vreemdeling { get; set; }

        public List<WettelijkeSamenwoning> WettelijkeSamenwoningen { get; set; } 


        #region "Adressen"

        public ActiefAdres ActiefAdres { get; set; }

        public List<OngestructureerdAdres> AangiftesBuitenlandsAdres { get; set; }

        public List<OngestructureerdAdres> AanvragenInschrijving { get; set; }

        public List<OngestructureerdAdres> AdresWijzigingen { get; set; }

        public List<OngestructureerdAdres> BuitenlandseAdressen { get; set; }

        public List<OngestructureerdAdres> BuitenlandsePostAdressen { get; set; }

        public List<OngestructureerdAdres> WettelijkeWoonplaatsen { get; set; }

        public List<GestructureerdAdres> OfficieleAdressen { get; set; }

        public List<ReferentieAdres> IsReferentieAdresPeriodes { get; set; }

        public List<GestructureerdAdres> GevalideerdBuitenlandsAdressen { get; set; }

        public List<GestructureerdAdres> VerblijfsAdressen { get; set; }

        public List<GestructureerdAdres> VerzendAdressen { get; set; }

        #endregion

        #region "Auditgegevens"

        public Audit Audit { get; set; }

        public BronAudit BronAudit { get; set; }

        public Bron Bron { get; set; }

        public Laag Laag { get; set; }

        public Toepassing Toepassing { get; set; }

        #endregion
    }
}
