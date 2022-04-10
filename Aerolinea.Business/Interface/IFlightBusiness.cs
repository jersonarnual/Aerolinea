using Aerolinea.Infraestructure.DTO;
using Aerolinea.Infraestructure.Util;
using System;
using System.Collections.Generic;

namespace Aerolinea.Business.Interface
{
    public interface IFlightBusiness
    {
        #region Flight
        Result GetAll();
        Result GetById(Guid id);
        Result Insert(FlightDTO entity);
        Result Update(FlightDTO entity);
        Result Delete(FlightDTO entity);
        #endregion

        #region FlightPath
        Result GetAllFlightPath();
        Result GetByIdFlightPath(Guid id);
        Result InsertFlightPath(FlightPathDTO entity);
        Result UpdateFlightPath(FlightPathDTO entity);
        Result DeleteFlightPath(FlightPathDTO entity);
        #endregion
    }
}
