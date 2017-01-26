using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace  Digipolis.Persoon.Api.Models.PersoonOpvraging
{
    public class PersoonLijstCriteria : CriteriaBase 
    {

        public List<String> Nummers { get; set; }

        public PersoonSleutelType Sleutel { get; set; }

        public List<PersoonEigenschap> GevraagdeEigenschappen { get; set; }

    }
}