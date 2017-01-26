using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Digipolis.Persoon.Api.Models
{
    
    abstract public class ResultaatBase
    {
       
        public virtual bool BevatFouten { get; set; }
       
        public virtual bool BevatWaarschuwingen { get; set; }
       
        public virtual List<Bericht> Berichten { get; set; }
       
        public int TotaalAantalResultaten { get; set; }

        public ResultaatBase()
        {
            Berichten = new List<Bericht>();
        }

        public void AddBericht(Bericht bericht)
        {
            Berichten.Add(bericht);
            if (bericht.Soort == BerichtSoort.Fout)
            {
                BevatFouten = true;
            }
            else if (bericht.Soort == BerichtSoort.Waarschuwing)
            {
                BevatWaarschuwingen = true;
            }
        }

        public void AddBerichten(List<Bericht> berichten)
        {
            if (berichten != null)
            {
                berichten.ForEach(bericht => AddBericht(bericht));
            }
        }

        public void AddFout(string tekst)
        {
            AddBericht(new Bericht() { Soort = BerichtSoort.Fout, Tekst = tekst });
        }

        public void AddFouten(IEnumerable<string> teksten)
        {
            foreach (string tekst in teksten)
            {
                AddFout(tekst);
            }
        }
    }
}
