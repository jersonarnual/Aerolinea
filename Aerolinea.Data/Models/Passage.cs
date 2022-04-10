using Aerolinea.Data.Models.Config;
using System;
using System.Collections.Generic;

namespace Aerolinea.Data.Models
{
    public class Passage : BaseEntity
    {
        public DateTime Time { get; set; }
        public string PositionNumber { get; set; }
        public string TypePassage { get; set; }
        public virtual ICollection<Flight> ListFlight { get; set; }
    }
}
