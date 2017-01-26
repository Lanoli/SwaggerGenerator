
using System.Runtime.Serialization;

namespace Digipolis.Persoon.Api.Models.PersoonSave
{
    
    public class Partner
    {
        
        public string RijksregisterNummer { get; set; }

        
        public string Familienaam { get; set; }

        
        public string Voornaam1 { get; set; }

        
        public string Voornaam2 { get; set; }

        
        public string Voornaam3 { get; set; }

        public string Voornamen
        {
            get { return string.Format("{0} {1} {2}", Voornaam1, Voornaam2, Voornaam3).Trim(); }
        }
    }
}