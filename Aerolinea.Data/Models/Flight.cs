using Aerolinea.Data.Models.Config;
using System;

namespace Aerolinea.Data.Models
{
    public class Flight : BaseEntity
    {
        public string Code { get; set; }
        public DateTime DateTimeFlight { get; set; }
    }
}
