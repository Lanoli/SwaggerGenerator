using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Digipolis.Persoon.Api.Models
{
    public class ExportCriteria
    {
        public DateTime? GewijzigdSinds { get; set; }
        public int? PersonenPerBestand { get; set; }
        public int? StartIndex { get; set; }
        public int? MaximumAantalPersonen { get; set; }
        public int? DelayMs { get; set; }

    }
}
