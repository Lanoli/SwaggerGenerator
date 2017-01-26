using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

using System.Xml.Serialization;

namespace Digipolis.Persoon.Api.Models.PersoonOpvraging
{
    public class GezinGetCriteria
    {
        public string Sleutel { get; set; }
        public PersoonSleutelType? SleutelType { get; set; }
    }
}