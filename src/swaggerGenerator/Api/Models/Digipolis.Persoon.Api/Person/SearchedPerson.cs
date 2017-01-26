namespace Digipolis.Persoon.Api.Models.Person
{
    public class SearchedPerson
    {
        public string NationalNumber { get; internal set; }
        public string FirstName { get; internal set; }
        public string LastName { get; internal set; }
        public string DateOfBirth { get; internal set; }
        public string PostalCode { get; internal set; }
    }
}