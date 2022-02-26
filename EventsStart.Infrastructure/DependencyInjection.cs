using EventsStar.Domain.Shared.Utility;
using Microsoft.Extensions.DependencyInjection;

namespace EventsStart.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<IDateTime, MachineDateTime>();
            return services;
        }
    }
}
