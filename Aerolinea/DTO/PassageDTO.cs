using System;
using System.Collections.Generic;

namespace Aerolinea.Infraestructure.DTO
{
    public class PassageDTO
    {
        public Guid Id
        {
            get; set;
        }
        public string CreateBy
        {
            get; set;
        }
        public string UpdateBy
        {
            get; set;
        }
        public DateTime? CreateTime
        {
            get; set;
        }
        public DateTime? UpdateTime
        {
            get; set;
        }
        public DateTime Time { get; set; }
        public string PositionNumber { get; set; }
        public string TypePassage { get; set; }
        public virtual ICollection<FlightDTO> ListFlightDTO { get; set; }
    }
}
