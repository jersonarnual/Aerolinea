using Aerolinea.Business.Interface;
using Aerolinea.Infraestructure.Util;
using Microsoft.AspNetCore.Mvc;
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
        public IEnumerable<object> GetAll()
        {
            Result model = _personBusiness.GetAll();
            if (object.Equals(model.ListModel, null))
                return null;
            return model.ListModel;
        }

    }
}
