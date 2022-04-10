using System;
using System.Collections.Generic;

namespace Aerolinea.Infraestructure.DTO
{
    public class AirplaneDTO
    {
        public Guid Id { get; set; }
        public string CreateBy { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string Code { get; set; }
        public int Capacity { get; set; }
        public string Description { get; set; }
        public virtual ICollection<FlightDTO> ListFlightDTO { get; set; }
    }
}
