using EventsStar.Domain.Base.Entites;
using EventsStar.Domain.Base.Specifications;
using System.Linq.Expressions;

namespace EventsStar.Domain.Base.Repositories
{
    public interface IRepository<T, TKey> where T : Entity<TKey>
    {
        Task<IReadOnlyList<T>> GetAllAsync();
        Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicate);
        Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicate,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy,
            string includeString = null,
            bool disableTracking = true);
        Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicate,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy,
            List<Expression<Func<T, object>>> includes,
            bool disableTracking = true);
        Task<IReadOnlyList<T>> GetAsync(ISpecification<T, TKey> spec);
        Task<T> GetByIdAsync(TKey id);
        Task<T> AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
    }
}
