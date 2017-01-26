using System.Runtime.Serialization;

namespace Digipolis.Persoon.Api.Models.PersoonSave
{
    
    public class BurgerlijkeStaat : Geldigheid
    {
        
        public string AkteNr { get; set; }

        
        public string Soort { get; set; }

        
        public string Omschrijving { get; set; }
        
        
        public Partner Partner{ get; set; }
        
        
        public Plaats GebeurtenisPlaats { get; set; }

        
        public string GebeurtenisDatum { get; set; }
        
        
        public string OverschrijvingDatum { get; set; }
        
        
        public Plaats OverschrijvingPlaats { get; set; }
        
        
        public string UitspraakDatum { get; set; }
        
        
        public Rechtbank UitspraakRechtbank { get; set; }
        
        
        public string AanvullendRegister { get; set; }
    }
}