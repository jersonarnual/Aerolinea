using Aerolinea.Business.Interface;
using Aerolinea.Business.Model;
using Aerolinea.Infraestructure.Util;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;


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
        public string Get()
        {
            string result = string.Empty;
            Result model = _pasaggeBusiness.GetAll();
            if (object.Equals(model, null))
                return result;
            result = JsonConvert.SerializeObject(model.ListModel);
            return result;
        }

        [HttpPost]
        public string Get(FilterPassage filterPassage)
        {
            string result = string.Empty;
            Result model = _pasaggeBusiness.GetFilter(filterPassage);
            if (object.Equals(model.ListModel, null))
                return result;
            result = JsonConvert.SerializeObject(model.ListModel);
            return result;
        }

        [HttpGet("{id}")]
        public string GetById(Guid id)
        {
            string result = string.Empty;
            Result model = _pasaggeBusiness.GetById(id);
            if (object.Equals(model.ListModel, null))
                return result;
            result = JsonConvert.SerializeObject(model.ListModel);
            return result;
        }

        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete]
        public void Delete([FromBody] string value)
        {
 
        }
    }
}
