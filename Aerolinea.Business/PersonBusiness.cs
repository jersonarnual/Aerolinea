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
    public class PersonBusiness : IPersonBusiness
    {
        #region Member
        private readonly IDefaultRepository<Person> _repository;
        #endregion

        #region Ctor
        public PersonBusiness(IDefaultRepository<Person> repository)
        {
            _repository = repository;
        }
        #endregion

        #region Methods
        public Result Delete(PersonDTO entity)
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
            List<PersonDTO> PersonDTO = new();
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
                    PersonDTO.Add(ConvertToDTO(item));

                result.ListModel = PersonDTO;
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

        public Result Insert(PersonDTO entity)
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

        public Result Update(PersonDTO entity)
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
        private static Person ConvertToModel(PersonDTO model)
        {
            if (model != null)
                return new Person()
                {
                    UpdateBy = model.UpdateBy ?? string.Empty,
                    CreateBy = model.CreateBy ?? string.Empty,
                    UpdateTime = model.UpdateTime,
                    CreateTime = model.CreateTime,
                    Id = model.Id,
                    FirtName = model.FirtName ?? string.Empty,
                    SecondName = model.SecondName ?? string.Empty,
                    Document = model.Document ?? string.Empty,
                    DateBirth = model.DateBirth,
                    CellPhone = model.CellPhone ?? string.Empty,
                    ListPassage = (ICollection<Passage>)model.ListPassageDTO,
                };
            return null;
        }

        private static PersonDTO ConvertToDTO(Person model)
        {
            if (model != null)
                return new PersonDTO()
                {
                    UpdateBy = model.UpdateBy ?? string.Empty,
                    CreateBy = model.CreateBy ?? string.Empty,
                    UpdateTime = model.UpdateTime,
                    CreateTime = model.CreateTime,
                    Id = model.Id,
                    FirtName = model.FirtName ?? string.Empty,
                    SecondName = model.SecondName ?? string.Empty,
                    Document = model.Document ?? string.Empty,
                    DateBirth = model.DateBirth,
                    CellPhone = model.CellPhone ?? string.Empty,
                    ListPassageDTO = (ICollection<PassageDTO>)model.ListPassage,
                };
            return null;
        }
        #endregion
    }
}
