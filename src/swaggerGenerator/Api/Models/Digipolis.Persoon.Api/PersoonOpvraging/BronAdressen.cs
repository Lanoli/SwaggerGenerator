using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace  Digipolis.Persoon.Api.Models.PersoonOpvraging
{
    
    public class BronAdressen 
    {

        public List<Adres> AangiftesBuitenlandsAdres { get; set; }

        public List<AanvraagInschrijving> AanvragenInschrijving { get; set; }

        public List<Adres> AdresWijzigingen { get; set; }

        public List<Adres> BuitenlandseAdressen { get; set; }

        public List<Adres> BuitenlandsePostAdressen { get; set; }

        public List<Adres> OfficieelAdressen { get; set; }

        public List<Adres> WettelijkeWoonplaatsen { get; set; }

        public List<ReferentieAdres> ReferentieAdressen { get; set; }

    }
}