using System;
using System.Collections.Generic;
using System.Text;

namespace _01_Framework.Infrastructure
{
    public interface IRepository<TKey,T> where T:class
    {
        void Create(T entity);
        void SaveChanges();
        List<T> GetAll();
        T GetByID(TKey id);
    }
}
