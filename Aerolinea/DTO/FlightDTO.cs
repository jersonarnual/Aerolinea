using System;

namespace Aerolinea.Infraestructure.DTO
{
    public class FlightDTO
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
        public string Code { get; set; }
        public DateTime DateTimeFlight { get; set; }

    }
}
