using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Digipolis.Persoon.Api.Models.Person
{
    public class Message
    {
        public Message()
        { }

        public Message(string text)
        {
            this.Text = text;
        }

        public string Text{ get; set; }
    }
}
