using Aerolinea.Business.Interface;
using Aerolinea.Data.Interface;
using Aerolinea.Data.Models;
using Aerolinea.Infraestructure.DTO;
using Aerolinea.Infraestructure.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aerolinea.Business
{
    public class FlightBusiness : IFlightBusiness
    {
        #region Member
        private readonly IDefaultRepository<Flight> _repository;
        private readonly IDefaultRepository<FlightPath> _flightPathRepository;
        #endregion

        #region Ctor
        public FlightBusiness(IDefaultRepository<Flight> repository,
                              IDefaultRepository<FlightPath> flightPathRepository)
        {
            _repository = repository;
            _flightPathRepository = flightPathRepository;
        }
        #endregion

        #region Methods Flight
        public Result Delete(FlightDTO entity)
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
            List<FlightDTO> flightDTO = new();
            try
            {
                var model = _repository.GetAll();
                if (!model.Any() || object.Equals(model, null))
                {
                    result.MessageException = $"ERROR: El objeto se encuentra vacio";
                    result.State = false;
                    return result;
                }
                foreach (var item in model)
                    flightDTO.Add(ConvertToDTO(item));

                result.ListModel = flightDTO;
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

        public Result Insert(FlightDTO entity)
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

        public Result Update(FlightDTO entity)
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

        #region methods Flight Path
        public Result DeleteFlightPath(FlightPathDTO entity)
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

                var model = ConvertToModelFlightPath(entity);
                if (_flightPathRepository.Delete(model))
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

        public Result GetAllFlightPath()
        {
            Result result = new();
            List<FlightPathDTO> flightDTO = new();
            try
            {
                var model = _flightPathRepository.GetAll();
                if (!model.Any() || object.Equals(model, null))
                {
                    result.MessageException = $"ERROR: El objeto se encuentra vacio";
                    result.State = false;
                    return result;
                }
                foreach (var item in model)
                    flightDTO.Add(ConvertToDTOFlightPath(item));

                result.ListModel = flightDTO;
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

        public Result GetByIdFlightPath(Guid id)
        {
            Result result = new();
            try
            {
                var model = _flightPathRepository.GetById(id);
                if (object.Equals(model, null))
                {
                    result.MessageException = $"ERROR: No se encontraron registros";
                    result.State = false;
                }
                result.Model = ConvertToDTOFlightPath(model);
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

        public Result InsertFlightPath(FlightPathDTO entity)
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

                var model = ConvertToModelFlightPath(entity);
                if (_flightPathRepository.Insert(model))
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

        public Result UpdateFlightPath(FlightPathDTO entity)
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

                var model = ConvertToModelFlightPath(entity);
                if (_flightPathRepository.Update(model))
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

        #region Methods Private Flight
        private static Flight ConvertToModel(FlightDTO model)
        {
            if (model != null)
                return new Flight()
                {
                    UpdateBy = model.UpdateBy,
                    CreateBy = model.CreateBy,
                    UpdateTime = (DateTime)model.UpdateTime,
                    CreateTime = (DateTime)model.CreateTime,
                    Id = model.Id,
                    Code = model.Code,
                    DateTimeFlight = model.DateTimeFlight
                };
            return null;
        }

        private static FlightDTO ConvertToDTO(Flight model)
        {
            if (model != null)
                return new FlightDTO()
                {
                    UpdateBy = model.UpdateBy,
                    CreateBy = model.CreateBy,
                    UpdateTime = model.UpdateTime,
                    CreateTime = model.CreateTime,
                    Id = model.Id,
                    Code = model.Code,
                    DateTimeFlight = model.DateTimeFlight
                };
            return null;
        }
        #endregion

        #region Methods private fligth path
        private static FlightPath ConvertToModelFlightPath(FlightPathDTO model)
        {
            if (model != null)
                return new FlightPath()
                {
                    UpdateBy = model.UpdateBy,
                    CreateBy = model.CreateBy,
                    UpdateTime = (DateTime)model.UpdateTime,
                    CreateTime = (DateTime)model.CreateTime,
                    Id = model.Id,
                    Price = model.Price,
                    ListFlight = (ICollection<Flight>)model.ListFlightDTO
                };
            return null;
        }

        private static FlightPathDTO ConvertToDTOFlightPath(FlightPath model)
        {
            if (model != null)
                return new FlightPathDTO()
                {
                    UpdateBy = model.UpdateBy,
                    CreateBy = model.CreateBy,
                    UpdateTime = (DateTime)model.UpdateTime,
                    CreateTime = (DateTime)model.CreateTime,
                    Id = model.Id,
                    Price = model.Price,
                    ListFlightDTO = (ICollection<FlightDTO>)model.ListFlight
                };
            return null;
        }
        #endregion
    }
}
