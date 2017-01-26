using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Serialization;

namespace Digipolis.Persoon.Api.Models.PersoonSave
{
    
    public class SaveResult : ResultaatBase
    {
        
        public string CrsPersoonnr { get; set; }
    }
}
