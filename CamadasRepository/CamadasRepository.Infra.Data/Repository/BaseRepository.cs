using CamadasRepository.Domain.Entities;
using CamadasRepository.Domain.Interfaces;
using CamadasRepository.Infra.Data.Context;
using System.Collections.Generic;
using System.Linq;

namespace CamadasRepository.Infra.Data.Repository
{
    public class BaseRepository<T>: IRepository<T> where T : BaseEntity
    {
        private MySqlContext context = new MySqlContext();

        public T Get(int id)
        {
            return context.Set<T>().Find(id);
        }

        public IList<T> GetAll()
        {
            return context.Set<T>().ToList();
        }

        public void Insert(T item)
        {
            context.Set<T>().Add(item);
            context.SaveChanges();
        }

        public void Remove(int id)
        {
            context.Set<T>().Remove(Get(id));
            context.SaveChanges();
        }

        public void Update(T item)
        {
            context.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }
    }
}
