using System;
using System.Collections.Generic;
using System.Linq;


namespace Digipolis.Web.Guidelines.Models
{
    public class Ok
    {
        public string Title { get; set; }

        /// <summary>
        /// De originele HTTP status code. 
        /// </summary>
        public int Status { get; set; }

        public string Detail { get; set; }
       
    }
}