using CamadasRepository.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CamadasRepository.Domain.Interfaces
{
    public interface IService<T> where T : BaseEntity
    {
        T Insert(T item);

        T Update(T item);

        void Delete(int id);

        T Get(int id);

        IList<T> GetAll();
    }
}
