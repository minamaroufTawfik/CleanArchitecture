using EventsStar.Application.Contracts.Common;
using EventsStar.Domain.Attendances;
using EventsStar.Domain.Events;
using EventsStar.Domain.Members;
using Microsoft.EntityFrameworkCore;

namespace EventsStar.EntityFrameworkCore
{
    public class EventsStarDbContext : DbContext, IEventsStarDbContext
    {
        public DbSet<Event> Events { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Attendance> Attendances { get; set; }

        public Task<int> SaveChangesAsync()
        {
            return base.SaveChangesAsync();
        }
    }
}
