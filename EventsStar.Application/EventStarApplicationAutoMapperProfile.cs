using AutoMapper;
using EventsStar.Application.Contracts.Events;
using EventsStar.Domain.Events;

namespace EventsStar.Application
{
    public class EventStarApplicationAutoMapperProfile : Profile
    {
        public EventStarApplicationAutoMapperProfile()
        {
            CreateMap<Event, EventDto>();
        }
    }

}
