using Aerolinea.Infraestructure.DTO;
using Aerolinea.Infraestructure.Util;
using System;

namespace Aerolinea.Business.Interface
{
    public interface IPersonBusiness
    {
        Result GetAll();
        Result GetById(Guid id);
        Result Insert(PersonDTO entity);
        Result Update(PersonDTO entity);
        Result Delete(PersonDTO entity);
    }
}
