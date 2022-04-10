﻿using System;
using System.Collections.Generic;

namespace Aerolinea.Infraestructure.DTO
{
    public class DepartmentDTO
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
        public string Name { get; set; }
        public virtual ICollection<CityDTO> ListCityDTO { get; set; }
    }
}
