using System;
using System.Collections.Generic;

namespace Aerolinea.Infraestructure.DTO
{
    public class PersonDTO
    {
        public Guid Id { get; set; }
        public string CreateBy { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string FirtName { get; set; }
        public string SecondName { get; set; }
        public string Document { get; set; }
        public DateTime DateBirth { get; set; }
        public string CellPhone { get; set; }
        public virtual ICollection<PassageDTO> ListPassageDTO { get; set; }
    }
}
