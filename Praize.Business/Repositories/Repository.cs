using Microsoft.EntityFrameworkCore;
using Praize.Business.Repositories.Interfaces;
using Praize.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Praize.Business.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected DbContext context = null;

        public Repository(DbContext dbContext)
        {
            context = dbContext;
        }

        public Task<TEntity> GetAsync(int id)
        {
            return context.Set<TEntity>().FindAsync(id);
        }

        public Task<List<TEntity>> GetAllAsync()
        {
            return context.Set<TEntity>().ToListAsync();
        }

        public Task<List<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return context.Set<TEntity>().Where(predicate).ToListAsync();
        }

        public Task<int> AddAsync(TEntity entity)
        {
            var dbSet = context.Set<TEntity>();
            dbSet.Add(entity);
            return context.SaveChangesAsync();
        }

        public void Add(TEntity entity)
        {
            context.Set<TEntity>().Add(entity);
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            context.Set<TEntity>().AddRange(entities);
        }

        public void Remove(TEntity entity)
        {
            context.Set<TEntity>().Remove(entity);
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            context.Set<TEntity>().RemoveRange(entities);
        }
    }
}
