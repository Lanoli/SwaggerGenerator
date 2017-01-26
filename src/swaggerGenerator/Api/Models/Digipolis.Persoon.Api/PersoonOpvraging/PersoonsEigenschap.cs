using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace  Digipolis.Persoon.Api.Models.PersoonOpvraging
{
    public class PersoonEigenschap 
    {

        public Eigenschap Eigenschap { get; set; }

        public Boolean MetHistoriek { get; set; }

    }
}