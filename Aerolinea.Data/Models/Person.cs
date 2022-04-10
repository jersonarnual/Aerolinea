using Aerolinea.Data.Models.Config;
using System;
using System.Collections.Generic;

namespace Aerolinea.Data.Models
{
    public class Person : BaseEntity
    {
        public string FirtName { get; set; }
        public string SecondName { get; set; }
        public string Document { get; set; }
        public DateTime DateBirth { get; set; }
        public string CellPhone { get; set; }
        public virtual ICollection<Passage> ListPassage { get; set; }

    }
}
