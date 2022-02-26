using AutoMapper;
using EventsStar.Application.Contracts.Events;
using EventsStar.Domain.Events;

namespace EventsStar.Application
{
    public class EventsStarAutoMapperProfile
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mapperConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<Event, EventDto>();
            });
            return mapperConfig;
        }
    }
}
