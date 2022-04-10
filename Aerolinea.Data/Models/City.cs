using Aerolinea.Data.Models.Config;
using System.Collections.Generic;

namespace Aerolinea.Data.Models
{
    public class City : BaseEntity
    {
        public string Name { get; set; }
        public virtual ICollection<FlightPath> ListFlightPath { get; set; }
    }
}
