using Aerolinea.Business.Interface;
using Aerolinea.Data.Interface;
using Aerolinea.Data.Models;
using Aerolinea.Infraestructure.DTO;
using Aerolinea.Infraestructure.Util;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Aerolinea.Business
{
    public class PassageBusiness: IPassageBusiness
    {
        #region Member
        private readonly IDefaultRepository<Passage> _repository;
        #endregion

        #region Ctor
        public PassageBusiness(IDefaultRepository<Passage> repository)
        {
            _repository = repository;
        }
        #endregion

        #region Methods
        public Result Delete(PassageDTO entity)
        {
            Result result = new();
            try
            {
                if (object.Equals(entity, null))
                {
                    result.MessageException = $"ERROR: El modelo se encuentra vacio";
                    result.State = false;
                    return result;
                }

                var model = ConvertToModel(entity);
                if (_repository.Delete(model))
                {
                    result.State = true;
                    result.Message = "Operacion Exitosa";
                    return result;
                }
                result.State = false;
                result.Message = "No se logro completar la operacion";
                return result;

            }
            catch (Exception ex)
            {
                result.MessageException = $"ERROR: {ex.Message} {ex.StackTrace}";
                result.State = false;
                return result;
            }
        }

        public Result GetAll()
        {
            Result result = new();
            List<PassageDTO> PassageDTO = new();
            try
            {
                var model = _repository.GetAll();
                if (!model.Any() || object.Equals(model, null))
                {
                    result.MessageException = $"ERROR: El objeto se encuentra vacio";
                    result.State = false;
                }
                foreach (var item in model)
                    PassageDTO.Add(ConvertToDTO(item));

                result.ListModel = PassageDTO;
                result.Message = "Operacion Exitosa";
                result.State = true;
                return result;
            }
            catch (Exception ex)
            {
                result.MessageException = $"ERROR: {ex.Message} {ex.StackTrace}";
                result.State = false;
                return result;
            }
        }

        public Result GetById(Guid id)
        {
            Result result = new();
            try
            {
                var model = _repository.GetById(id);
                if (object.Equals(model, null))
                {
                    result.MessageException = $"ERROR: No se encontraron registros";
                    result.State = false;
                }
                result.Model = ConvertToDTO(model);
                result.Message = "Operacion Exitosa";
                result.State = true;
                return result;
            }
            catch (Exception ex)
            {
                result.MessageException = $"ERROR: {ex.Message} {ex.StackTrace}";
                result.State = false;
                return result;
            }
        }

        public Result Insert(PassageDTO entity)
        {
            Result result = new();
            try
            {
                if (object.Equals(entity, null))
                {
                    result.MessageException = $"ERROR: El modelo se encuentra vacio";
                    result.State = false;
                    return result;
                }

                var model = ConvertToModel(entity);
                if (_repository.Insert(model))
                {
                    result.State = true;
                    result.Message = "Operacion Exitosa";
                    return result;
                }
                result.State = false;
                result.Message = "No se logro completar la operacion";
                return result;
            }
            catch (Exception ex)
            {
                result.MessageException = $"ERROR: {ex.Message} {ex.StackTrace}";
                result.State = false;
                return result;
            }
        }

        public Result Update(PassageDTO entity)
        {
            Result result = new();
            try
            {
                if (object.Equals(entity, null))
                {
                    result.MessageException = $"ERROR: El modelo se encuentra vacio";
                    result.State = false;
                    return result;
                }

                var model = ConvertToModel(entity);
                if (_repository.Update(model))
                {
                    result.State = true;
                    result.Message = "Operacion Exitosa";
                    return result;
                }
                result.State = false;
                result.Message = "No se logro completar la operacion";
                return result;
            }
            catch (Exception ex)
            {
                result.MessageException = $"ERROR: {ex.Message} {ex.StackTrace}";
                result.State = false;
                return result;
            }
        }
        #endregion

        #region Methods Private
        private static Passage ConvertToModel(PassageDTO model)
        {
            if (model != null)
                return new Passage()
                {
                    UpdateBy = model.UpdateBy,
                    CreateBy = model.CreateBy,
                    UpdateTime = (DateTime)model.UpdateTime,
                    CreateTime = (DateTime)model.CreateTime,
                    Id = model.Id,
                    Time = model.Time,
                    PositionNumber = model.PositionNumber,
                    TypePassage = model.TypePassage,
                    ListFlight = (ICollection<Flight>)model.ListFlightDTO
                };
            return null;
        }

        private static PassageDTO ConvertToDTO(Passage model)
        {
            if (model != null)
                return new PassageDTO()
                {
                    UpdateBy = model.UpdateBy,
                    CreateBy = model.CreateBy,
                    UpdateTime = (DateTime)model.UpdateTime,
                    CreateTime = (DateTime)model.CreateTime,
                    Id = model.Id,
                    Time = model.Time,
                    PositionNumber = model.PositionNumber,
                    TypePassage = model.TypePassage,
                    ListFlightDTO = (ICollection<FlightDTO>)model.ListFlight
                };
            return null;
        }
        #endregion
    }
}
