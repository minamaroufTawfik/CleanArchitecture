namespace EventsStar.Domain.Events
{
    public class EventManager
    {
        public IEventRepository EventRepository { get; set; }
        public EventManager(IEventRepository eventRepository)
        {
            EventRepository = eventRepository;
        }
    }
}
