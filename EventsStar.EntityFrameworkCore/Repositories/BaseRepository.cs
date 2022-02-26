using EventsStar.Domain.Base.Entites;
using EventsStar.Domain.Base.Repositories;
using EventsStar.Domain.Base.Specifications;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace EventsStar.EntityFrameworkCore.Repositories
{
    public class Repository<T, TKey> : IRepository<T, TKey>  where T : Entity<TKey>
    {
        protected readonly EventsStarDbContext DbContext;

        public Repository(EventsStarDbContext dbContext)
        {
            DbContext = dbContext;
        }

        public async Task<IReadOnlyList<T>> GetAllAsync()
        {
            return await DbContext.Set<T>().ToListAsync();
        }

        public async Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicate)
        {
            return await DbContext.Set<T>().Where(predicate).ToListAsync();
        }

        public async Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicate, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy, string includeString = null, bool disableTracking = true)
        {
            IQueryable<T> query = DbContext.Set<T>();
            if (disableTracking) query = query.AsNoTracking();

            if (!string.IsNullOrWhiteSpace(includeString)) query = query.Include(includeString);

            if (predicate != null) query = query.Where(predicate);

            if (orderBy != null)
                return await orderBy(query).ToListAsync();
            return await query.ToListAsync();
        }

        public async Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicate, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy, List<Expression<Func<T, object>>> includes = null, bool disableTracking = true)
        {
            IQueryable<T> query = DbContext.Set<T>();
            if (disableTracking) query = query.AsNoTracking();

            if (includes != null) query = includes.Aggregate(query, (current, include) => current.Include(include));

            if (predicate != null) query = query.Where(predicate);

            if (orderBy != null)
                return await orderBy(query).ToListAsync();
            return await query.ToListAsync();
        }

        public virtual async Task<T> GetByIdAsync(int id)
        {
            return await DbContext.Set<T>().FindAsync(id);
        }

        public async Task<T> AddAsync(T entity)
        {
            DbContext.Set<T>().Add(entity);
            await DbContext.SaveChangesAsync();
            return entity;
        }

        public async Task UpdateAsync(T entity)
        {
            DbContext.Entry(entity).State = EntityState.Modified;
            await DbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            DbContext.Set<T>().Remove(entity);
            await DbContext.SaveChangesAsync();
        }

        public Task<IReadOnlyList<T>> GetAsync(ISpecification<T, TKey> spec)
        {
            throw new NotImplementedException();
        }

        public async Task<T> GetByIdAsync(TKey id)
        {
            return await DbContext.Set<T>().FindAsync(id);
        }
    }
}
