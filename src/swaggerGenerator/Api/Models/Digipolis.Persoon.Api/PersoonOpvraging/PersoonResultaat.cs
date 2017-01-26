using Digipolis.Persoon.Api.Models.PersoonOpvraging;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace  Digipolis.Persoon.Api.Models.PersoonOpvraging
{
    
    public class PersoonResultaat
    {
        public PersoonResultaat()
        {
            Berichten = new List<Bericht>();
        }

        public int? TotaalAantalResultaten { get; set; }

        public List<Persoon> Personen { get; set; }

        public String OperatieSleutel { get; set; }

        public Boolean BevatFouten { get; set; }

        public Boolean BevatWaarschuwingen { get; set; }

        public List<Bericht> Berichten { get; set; }

        public Bericht AddBericht(BerichtSoort soort, String tekst)
        {
            var nieuwBericht = new Bericht(soort, tekst);
            Berichten.Add(nieuwBericht);
            if (soort == BerichtSoort.Fout || soort == BerichtSoort.KritischeFout)
            {
                BevatFouten = true;
            }
            else if (soort == BerichtSoort.Waarschuwing)
            {
                BevatWaarschuwingen = true;
            }
            return nieuwBericht;
        }

    }
}