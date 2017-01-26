using System.Runtime.Serialization;

namespace Digipolis.Persoon.Api.Models.PersoonSave
{
    
    public class Paspoort : Geldigheid
    {
        
        public string Inhoud { get; set; }
    }
}