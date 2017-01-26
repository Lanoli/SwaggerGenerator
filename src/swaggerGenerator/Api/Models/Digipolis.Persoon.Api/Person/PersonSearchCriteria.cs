namespace Digipolis.Persoon.Api.Models.Person
{
    public class PersonSearchCriteria
    {
        public string NationalNumber { get;  set; }
        public string FirstName { get;  set; }
        public string LastName { get;  set; }
        public int PageNumber { get; set; }
        public int PageLength { get; set; }
        public SortByField? SortBy { get; set; }
        public bool SortReversed { get; set; }

        public enum SortByField
        {
            NationalNumber,
            FirstName,
            LastName
        }

    }
}