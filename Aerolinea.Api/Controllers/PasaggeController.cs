using Aerolinea.Business.Interface;
using Aerolinea.Business.Model;
using Aerolinea.Infraestructure.DTO;
using Aerolinea.Infraestructure.Util;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Aerolinea.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PasaggeController : ControllerBase
    {

        private readonly IPassageBusiness _pasaggeBusiness;

        public PasaggeController(IPassageBusiness pasaggeBusiness)
        {
            _pasaggeBusiness = pasaggeBusiness;
        }

        [HttpGet]
        public IEnumerable<object> Get()
        {
            Result model = _pasaggeBusiness.GetAll();
            if (object.Equals(model.ListModel, null))
                return null;
            return model.ListModel;
        }

        [HttpPost]
        public IEnumerable<object> Get(FilterPassage filterPassage)
        {
            Result model = _pasaggeBusiness.GetFilter(filterPassage);
            if (object.Equals(model.ListModel, null))
                return null;
            return model.ListModel;
        }

        [HttpGet("{id}")]
        public object GetById(Guid id)
        {
            Result model = _pasaggeBusiness.GetById(id);
            if (object.Equals(model.ListModel, null))
                return null;
            return model.ListModel;
        }

        [HttpPost]
        public void Post(PassageDTO value)
        {
        }

        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody] string value)
        {
        }

        [HttpDelete]
        public void Delete([FromBody] string value)
        {

        }
    }
}
