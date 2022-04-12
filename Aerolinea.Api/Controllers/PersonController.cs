using Aerolinea.Business.Interface;
using Aerolinea.Infraestructure.DTO;
using Aerolinea.Infraestructure.Util;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Aerolinea.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonBusiness _personBusiness;

        public PersonController(IPersonBusiness personBusiness)
        {
            _personBusiness = personBusiness;
        }

        [HttpGet]
        public string GetAll()
        {
            string result = string.Empty;
            Result model = _personBusiness.GetAll();
            if (object.Equals(model, null))
                return result;
            result = JsonConvert.SerializeObject(model.ListModel);
            return result;
        }
    
    }
}
