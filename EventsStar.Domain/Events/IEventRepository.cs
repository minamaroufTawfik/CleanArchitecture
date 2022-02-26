using EventsStar.Domain.Base.Repositories;

namespace EventsStar.Domain.Events
{
    public interface IEventRepository: IRepository<Event, Guid>
    {
        Task<Event> FindByNameAsync(string name);
    }
}
