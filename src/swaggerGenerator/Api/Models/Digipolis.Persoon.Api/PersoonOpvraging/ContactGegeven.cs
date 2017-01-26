using System;
using System.Runtime.Serialization;

namespace  Digipolis.Persoon.Api.Models.PersoonOpvraging
{
    
    public class ContactGegeven
    {

        public String CrsPersoonNr { get; set; }

        public String Code { get; set; }

        public String Inhoud { get; set; }

        public String Omschrijving { get; set; }

        public String Opmerking { get; set; }

        public String Herkomst { get; set; }

        public Boolean IsGevalideerd { get; set; }

        public DateTime CreatieDatum { get; set; }

    }
}