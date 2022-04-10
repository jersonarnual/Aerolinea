using Aerolinea.Data.Models.Config;
using System.Collections.Generic;

namespace Aerolinea.Data.Models
{
    public class Country : BaseEntity
    {
        public string Name { get; set; }
        public virtual ICollection<Department> ListDepartment { get; set; }
    }
}
