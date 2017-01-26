using System;
using System.Runtime.Serialization;

namespace  Digipolis.Persoon.Api.Models.PersoonOpvraging
{
    

    public enum AdresSoort
    {
        Onbekend,
        AangifteBuitenlandsAdres,
        AanvraagInschrijving,
        AdresWijziging,
        BuitenlandsAdres,
        BuitenlandsPostAdres,
        OfficieelAdres,
        WettelijkeWoonplaats,
        GevalideerdBuitenlandsAdres,
        VerzendAdres,
        VerblijfsAdres
    }
}