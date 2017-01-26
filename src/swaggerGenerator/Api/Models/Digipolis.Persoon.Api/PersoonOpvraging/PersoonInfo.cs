namespace Digipolis.Persoon.Api.Models.PersoonOpvraging
{
    public class PersoonInfo
    {
        public string PersoonNr { get; set; }
        public string FamilieNaam { get; set; }
        public string Voornaam { get; set; }
        public Geslacht Geslacht { get; set; }
        public GeboorteInfo Geboorte { get; set; }
        public BurgerlijkeStaatInfo BurgerlijkeStaat { get; set; }
        public string RijksregisterNummer { get; set; }
        public AdresInfo Adres { get; set; }
        public OverlijdenInfo Overlijden { get; set; }
        public BronInfo Bron { get; set; }
        public LaagInfo Laag { get; set; }
        public string Nationaliteit { get; set; }
        public WettelijkSamenwonendInfo WettelijkSamenwonend { get; set; }
    }
}
