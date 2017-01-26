using System;
using System.Text.RegularExpressions;

namespace Digipolis.Persoon.Api.Models.Person.Validators
{
    public sealed class PersonSearchCriteriaValidator
    {
        public static void Validate(PersonSearchCriteria personSearchCriteria)
        {
            if (string.IsNullOrWhiteSpace(personSearchCriteria.FirstName) && string.IsNullOrWhiteSpace(personSearchCriteria.LastName) && string.IsNullOrWhiteSpace(personSearchCriteria.NationalNumber))
                throw new ArgumentException(string.Format("At least one of the following parameters need to contain a value: {0},{1},{2} ", "FirstName", "LastName", "NationalNumber"));

            if (!string.IsNullOrWhiteSpace(personSearchCriteria.NationalNumber) && Regex.IsMatch(personSearchCriteria.NationalNumber, @"^\d+$"))
                throw new ArgumentException(string.Format("Value for parameter '{0}' is not a valid national number", "NationalNumber"));
        }
    }
}