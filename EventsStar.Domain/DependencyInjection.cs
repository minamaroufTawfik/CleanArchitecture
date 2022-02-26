using EventsStar.Domain.Attendances;
using EventsStar.Domain.Members;
using Microsoft.Extensions.DependencyInjection;

namespace EventsStar.Domain
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDomainServices(this IServiceCollection services)
        {
            services.AddScoped<MemberManager>();
            services.AddScoped<AttendanceManager>();
            return services;
        }
    }
}
