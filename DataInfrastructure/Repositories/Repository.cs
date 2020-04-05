using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
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
        
        #region Metodos no-async
        
        public void Add(TEntity entity)=> _context.Set<TEntity>().Add(entity);                  
        public void AddRange(IEnumerable<TEntity> entities)=> _context.AddRange(entities);
        public void Remove(TEntity entity)=> _context.Set<TEntity>().Remove(entity);
        public void RemoveRange(IEnumerable<TEntity> entities) => _context.Set<TEntity>().RemoveRange(entities);
        public void Update(TEntity entity) => _context.Set<TEntity>().Update(entity);
        public void UpdateRange(IEnumerable<TEntity> entities) => _context.Set<TEntity>().UpdateRange(entities);
        #endregion

        #region Metodos Async
        public async Task<List<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate)=> 
            await _context.Set<TEntity>().Where(predicate).ToListAsync();
        public async Task<IEnumerable<TEntity>> GetAllAsync()=> await _context.Set<TEntity>().ToListAsync();
        public async Task<TEntity> GetByIdAsync(int id)=> await _context.Set<TEntity>().FindAsync(id);        
        public async Task<int> SaveAsync() => await _context.SaveChangesAsync();                
        #endregion        
    }
}