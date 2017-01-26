using System;
using System.Collections.Generic;
using System.Linq;


namespace Digipolis.Persoon.Api.Models.Person
{
    public class ResultBase
    {
        public ResultBase()
        {
            Messages = new List<Message>();
        }

        public List<Message> Messages { get; set; }
    }
}