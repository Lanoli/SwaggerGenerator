using System;
using System.Collections.Generic;
using System.Linq;


namespace Digipolis.Persoon.Api.Models.Person
{
    public class Person
    {
        public string CrsNumber { get; set; }

        public string NationalNumber { get; set; }

        public string GenderCode { get; set; }

        public string BirthDate { get; set; }

        public string GivenName { get; set; }

        public string FamilyName { get; set; }

        public string DeathDate { get; set; }

        public string StreetName { get; set; }

        public string HouseNumber { get; set; }

        public string HouseNumberExtension { get; set; }

        public string PostalCode { get; set; }

        public string MunicipalityName { get; set; }

    }
}