using Aerolinea.Data.Models.Config;
using System.Collections.Generic;

namespace Aerolinea.Data.Models
{
    public class Airplane : BaseEntity
    {
        public string Code { get; set; }
        public int Capacity { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Flight> ListFlight { get; set; }
    }
}
