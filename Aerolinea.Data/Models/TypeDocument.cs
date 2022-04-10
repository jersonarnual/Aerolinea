using Aerolinea.Data.Models.Config;
using System.Collections.Generic;

namespace Aerolinea.Data.Models
{
    public class TypeDocument : BaseEntity
    {
        public string Name { get; set; }
        public virtual ICollection<Person> ListPeople { get; set; }
    }
}
