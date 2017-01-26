using System;
using System.Collections.Generic;
using System.Linq;


namespace Digipolis.Persoon.Api.Models.Person
{
    public class ContactInfo
    {
        public string Code { get; set; }

        public string Content { get; set; }

        public string Description { get; set; }

        public string Comment { get; set; }

        public bool IsValidated { get; set; }
    }
}