using AutoMapper;
using EventsStar.Application.Attendances;
using EventsStar.Application.Contracts.Attendances;
using EventsStar.Application.Contracts.Events;
using EventsStar.Application.Contracts.Members;
using EventsStar.Application.Events;
using EventsStar.Application.Members;
using EventsStar.Domain.Events;
using Microsoft.Extensions.DependencyInjection;

namespace EventsStar.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            IMapper mapper = RegisterMaps().CreateMapper();
            services.AddSingleton(mapper);

            services.AddScoped<IEventAppService, EventAppService>();
            services.AddScoped<IMemberAppService, MemberAppService>();
            services.AddScoped<IAttendanceAppService, AttendanceAppService>();
            return services;
        }

        private static MapperConfiguration RegisterMaps()
        {
            var mapperConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<Event, EventDto>().ReverseMap();
            });
            return mapperConfig;
        }
    }
}
