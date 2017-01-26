using System;
using System.Collections.Generic;
using System.Linq;


namespace Digipolis.Persoon.Api.Models.Person
{
    public class PersonContactInfoGetCriteria
    {
        public string key { get; set; }
        public PersonKeyType? PersonKeyType { get; set; }
    }
}