using Aerolinea.Data.Models.Config;
using System.Collections.Generic;

namespace Aerolinea.Data.Models
{
    public class FlightPath : BaseEntity
    {
        public decimal Price { get; set; }
        public virtual ICollection<Flight> ListFlight { get; set; }
    }
}
