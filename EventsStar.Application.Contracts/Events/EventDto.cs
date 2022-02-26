using EventsStar.Application.Contracts.Base.Dto;
using EventsStar.Domain.Shared.Events;

namespace EventsStar.Application.Contracts.Events
{
    public class EventDto : EntityDto<Guid>
    {
        public string Name { get; set; }
        public string PlaceName { get; set; }
        public string Desription { get; set; }
        public int Duration { get; set; }
        public EventDurationType DurationType { get; set; }
    }
}
