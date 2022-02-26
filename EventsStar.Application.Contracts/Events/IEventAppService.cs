namespace EventsStar.Application.Contracts.Events
{
    public interface IEventAppService
    {
        Task<EventDto> GetAsync(Guid id);
    }
}
