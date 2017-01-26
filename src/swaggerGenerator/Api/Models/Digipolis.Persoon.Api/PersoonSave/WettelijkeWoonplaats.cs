using System.Runtime.Serialization;

namespace Digipolis.Persoon.Api.Models.PersoonSave
{
    public class WettelijkeWoonplaats : Geldigheid
    {
        public string Ongestructureerd { get; set; }
        public int HernummeringNummer { get; set; }
    }
}