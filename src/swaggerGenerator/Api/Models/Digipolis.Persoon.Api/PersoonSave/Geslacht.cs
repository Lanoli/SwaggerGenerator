using System.Runtime.Serialization;

namespace Digipolis.Persoon.Api.Models.PersoonSave
{

     
    public class Geslacht : Geldigheid
    {
         
         public string GeslachtSoort{ get; set; }
    }


    // GeslachtSoort is omgezet van enum naar string
    // save-logica zal hieraan aangepast moeten worden.  -- pol
     //
     //public enum GeslachtSoortEnum
     //{
     //    [EnumMember(Value = "Onbekend")]
     //    Onbekend,
     //    [EnumMember(Value = "Man")]
     //    Man,
     //    [EnumMember(Value = "Vrouw")]
     //    Vrouw

     //}

}
