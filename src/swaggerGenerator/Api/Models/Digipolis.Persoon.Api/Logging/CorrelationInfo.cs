using System;
using System.Collections.Generic;
using System.Linq;


namespace Digipolis.Persoon.Api.Models.Logging
{
    public class CorrelationInfo
    {
        public string Id { get; set; }
        public string AppName { get; set; }
        public string UserId { get; set; }
        public string IpAddress { get; set; }
    }
}