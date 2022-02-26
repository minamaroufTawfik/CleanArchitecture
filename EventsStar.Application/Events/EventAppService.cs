using AutoMapper;
using EventsStar.Application.Contracts.Events;
using EventsStar.Domain.Events;

namespace EventsStar.Application.Events
{
    public class EventAppService : IEventAppService
    {
        private IEventRepository EventRepository { get; }
        private IMapper Mapper { get; }
        public EventAppService(IEventRepository eventRepository, IMapper mapper)
        {
            EventRepository = eventRepository;
            Mapper = mapper;
        }
        public async Task<EventDto> GetAsync(Guid id)
        {
            Event @event = await EventRepository.GetByIdAsync(id);
            return Mapper.Map<EventDto>(@event);
        }
    }
}
