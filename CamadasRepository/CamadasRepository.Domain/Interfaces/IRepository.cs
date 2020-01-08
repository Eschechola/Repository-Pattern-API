using CamadasRepository.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CamadasRepository.Domain.Interfaces
{
    public interface IRepository<T> where T : BaseEntity 
    {
        void Insert(T item);

        void Update(T item);

        void Remove(int id);

        T Get(int id);

        IList<T> GetAll();
    }
}
