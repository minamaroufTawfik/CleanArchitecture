using EventsStar.Domain.Attendances;
using EventsStar.Domain.Events;
using EventsStar.Domain.Members;
using Microsoft.EntityFrameworkCore;

namespace EventsStar.Application.Contracts.Common
{
    public interface IEventsStarDbContext
    {
        DbSet<Event> Events { get; set; }
        DbSet<Member> Members { get; set; }
        DbSet<Attendance> Attendances { get; set; }
        Task<int> SaveChangesAsync();
    }
}
