using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

using System.Xml.Serialization;

namespace Digipolis.Persoon.Api.Models.PersoonOpvraging
{
    public class PersoonGetCriteria
    {
        public PersoonGetCriteria()
        {
            Eigenschappen = new List<Eigenschap>();
            Sleutels = new List<string>(); 
        }

        public string Sleutel { get; set; }
        public List<string> Sleutels { get; set; }
        public PersoonSleutelType? SleutelType { get; set; }
        public List<Eigenschap> Eigenschappen { get; set; }

       

    }
}