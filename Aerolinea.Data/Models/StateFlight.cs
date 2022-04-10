using Aerolinea.Data.Models.Config;
using System.Collections.Generic;

namespace Aerolinea.Data.Models
{
    public class StateFlight : BaseEntity
    {
        public string Name { get; set; }
        public virtual ICollection<Flight> ListFlight { get; set; }
    }
}
