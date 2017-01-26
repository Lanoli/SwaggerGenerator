using System;
using System.Collections.Generic;
using System.Linq;


namespace Digipolis.Persoon.Api.Models.Person
{
    public class PersonGetCriteria
    {
        public string Key { get; set; }
        public PersonKeyType? PersonKeyType { get; set; }
    }
}