using System;
using System.Collections.Generic;
using System.Linq;


namespace Digipolis.Persoon.Api.Models.Person
{
    public class ContactInfoGetResult:ResultBase
    {
        public ContactInfoGetResult()
        {
            ContactInfo = new List<ContactInfo>();
        }
        public List<ContactInfo> ContactInfo { get; set; }
    }
}