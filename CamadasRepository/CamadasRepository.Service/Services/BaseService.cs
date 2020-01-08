using CamadasRepository.Domain.Entities;
using CamadasRepository.Domain.Interfaces;
using CamadasRepository.Infra.Data.Repository;
using CamadasRepository.Service.Validator;
using System;
using System.Collections.Generic;
using System.Text;

namespace CamadasRepository.Service.Services
{
    public class BaseService<T> : IService<T> where T : BaseEntity
    {

        private BaseRepository<T> repository = new BaseRepository<T>();

        public T Insert(T item)
        {
            //caso o usuario esteja inválido ele irá retornar uma excessã
            //que será tratada no controller
            new BaseValidator<T>().IsValid(item);

            repository.Insert(item);
            return item;
        }

        public T Update(T item)
        {
            //caso o usuario esteja inválido ele irá retornar uma excessã
            //que será tratada no controller
            new BaseValidator<T>().IsValid(item);


            repository.Update(item);
            return item;
        }

        public void Delete(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("O id não pode ser menor ou igual a ZERO.");
            }

            repository.Remove(id);
        }

        public T Get(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("O id não pode ser menor ou igual a ZERO.");
            }

            return repository.Get(id);
        }

        public IList<T> GetAll()
        {
            return repository.GetAll();
        }

    }
}
