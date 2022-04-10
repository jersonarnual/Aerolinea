using Aerolinea.Data.Models.Config;
using System.Collections.Generic;

namespace Aerolinea.Data.Models
{
    public class Airline : BaseEntity
    {
        public string Name { get; set; }
        public virtual ICollection<Airplane> ListAirplane { get; set; }
    }
}
