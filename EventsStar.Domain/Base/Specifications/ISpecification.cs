using EventsStar.Domain.Base.Entites;
using System.Linq.Expressions;

namespace EventsStar.Domain.Base.Specifications
{
    public class ISpecification<T, TKey> where T : Entity<TKey>
    {
        Expression<Func<T, bool>> Criteria { get; }
        List<Expression<Func<T, object>>> Includes { get; }
        List<string> IncludeStrings { get; }
        Expression<Func<T, object>> OrderBy { get; }
        Expression<Func<T, object>> OrderByDescending { get; }
        int Take { get; }
        int Skip { get; }
        bool IsPagingEnabled { get; }
    }
}
