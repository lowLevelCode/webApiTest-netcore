using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace webApiTest.Domain.SuperTypes
{
    public interface IRepository<T> where T : AggregateRoot
    {
        void Add(T entity);
        void AddRange(IEnumerable<T> entities);
        T GetById(int id);
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);        
        void Update(T entity);
        void Update(IEnumerable<T> entities);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
        int Save();
    }
}