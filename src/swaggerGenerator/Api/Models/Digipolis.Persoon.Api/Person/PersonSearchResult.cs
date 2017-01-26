using System.Collections.Generic;

namespace Digipolis.Persoon.Api.Models.Person
{
    public class PersonSearchResult
    {
        public PersonSearchResult()
        {
            Messages = new List<Message>();
        }
        public IEnumerable<SearchedPerson> Data  { get; set; }
        public List<Message> Messages { get; set; }
        public int TotalCount { get; set; }
    }
}