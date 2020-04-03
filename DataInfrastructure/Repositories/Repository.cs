using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using webApiTest.Domain.SuperTypes;

namespace webApiTest.DataInfrastruture.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : AggregateRoot
    {
        protected readonly AforeGlobalContext _context;

        public Repository(AforeGlobalContext context)
        {
            _context = context;
        }

        public void Add(TEntity entity) => _context.Set<TEntity>().Add(entity);

        public void AddRange(IEnumerable<TEntity> entities) => _context.AddRange(entities);

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate) =>
            _context.Set<TEntity>().Where(predicate);

        public IEnumerable<TEntity> GetAll()=> _context.Set<TEntity>().ToList();

        public TEntity GetById(int id) => _context.Set<TEntity>().Find(id);

        public void Remove(TEntity entity) => _context.Set<TEntity>().Remove(entity);

        public void RemoveRange(IEnumerable<TEntity> entities) => 
            _context.Set<TEntity>().RemoveRange(entities);

        public int Save()
        {
            return _context.SaveChanges();
        }

        public void Update(TEntity entity) => _context.Set<TEntity>().Update(entity);

        public void Update(IEnumerable<TEntity> entities) => 
            _context.Set<TEntity>().UpdateRange(entities);
    }
}