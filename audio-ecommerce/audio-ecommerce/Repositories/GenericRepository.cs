using audio_ecommerce.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace audio_ecommerce.Repositories
{

    public class GenericRepository<T> : IGenericRepository<T> where T : class, IEntity
    {
        private readonly DbContext _dbContext;

        public GenericRepository(DbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public T Create(T entity)
        {
            DateTime now = DateTime.UtcNow;
            Console.WriteLine(now);
            entity.CreatedDate = now;
            entity.ModifiedDate = now;
            entity.IsDeleted = false;
            _dbContext.Set<T>().Add(entity);
            return entity;
        }

        public void Delete(T entity)
        {
            entity.ModifiedDate = DateTime.UtcNow;
            entity.IsDeleted = true;
            _dbContext.Set<T>().Update(entity);

        }

        public T GetById(int id, params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> entities = _dbContext.Set<T>();
            if (includes != null)
            {
                foreach (var include in includes)
                {
                    entities = entities.Include(include);
                }
            }
            return entities.FirstOrDefault(e => e.Id == id);
        }

        public IQueryable<T> GetAll(params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> entities = _dbContext.Set<T>();
            if (includes != null)
            {
                foreach (var include in includes)
                {
                    entities = entities.Include(include);
                }
            }
            return entities;
        }



        public T Update(T entity)
        {
            entity.ModifiedDate = DateTime.UtcNow;
            _dbContext.Set<T>().Update(entity);
            return entity;
        }
    }
}