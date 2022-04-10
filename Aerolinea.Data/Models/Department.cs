using Aerolinea.Data.Models.Config;
using System.Collections.Generic;

namespace Aerolinea.Data.Models
{
    public class Department: BaseEntity
    {
        public string Name { get; set; }
        public virtual ICollection<City> ListCity { get; set; }
    }
}
