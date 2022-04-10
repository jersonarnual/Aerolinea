using Aerolinea.Infraestructure.DTO;
using Aerolinea.Infraestructure.Util;
using System;

namespace Aerolinea.Business.Interface
{
    public interface IPassageBusiness
    {
        Result GetAll();
        Result GetById(Guid id);
        Result Insert(PassageDTO entity);
        Result Update(PassageDTO entity);
        Result Delete(PassageDTO entity);
    }
}
