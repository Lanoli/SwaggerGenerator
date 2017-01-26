using System.Runtime.Serialization;

namespace Digipolis.Persoon.Api.Models.PersoonSave
{
    
    public class Plaats
    {
       
        public string NisCode { get; set; }

        
        public string PostCode { get; set; }

        
        public string Naam { get; set; }

        
        public Land Land { get; set; }
    }
}