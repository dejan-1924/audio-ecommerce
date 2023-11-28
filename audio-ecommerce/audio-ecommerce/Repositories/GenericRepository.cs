using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace audio_ecommerce.Repositories
{

    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly DbContext _dbContext;

        public GenericRepository(DbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public async Task<T> Create(T entity)
        {
            DateTime now = DateTime.UtcNow;
            entity.CreatedDate = now;
            entity.ModifiedDate = now;
            await _dbContext.Set<T>().AddAsync(entity);
            return entity;
        }

        public void Delete(T entity)
        {
            entity.ModifiedDate = DateTime.UtcNow;
            entity.IsDeleted = true;
            _dbContext.Set<T>().Update(entity);
        }

        public async Task<T?> GetById(long id, params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> entities = _dbContext.Set<T>();
            if (includes != null)
            {
                foreach (var include in includes)
                {
                    entities = entities.Include(include);
                }
            }
            return await entities
                .FirstOrDefaultAsync(e => e.Id == id);
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