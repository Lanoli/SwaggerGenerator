using System;
using System.Collections.Generic;
using System.Linq;


namespace Digipolis.Persoon.Api.Models.Person
{
    public class PersonGetResult : ResultBase
    {
        public Person Person { get; set; }
    }
}