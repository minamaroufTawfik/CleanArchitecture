using EventsStar.Application.Contracts.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EventsStar.EntityFrameworkCore
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddEFCore(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<EventsStarDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<IEventsStarDbContext, EventsStarDbContext>();
            return services;
        }
    }
}