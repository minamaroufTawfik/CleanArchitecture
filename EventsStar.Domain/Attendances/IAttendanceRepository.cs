using EventsStar.Domain.Base.Repositories;

namespace EventsStar.Domain.Attendances
{
    public interface IAttendanceRepository : IRepository<Attendance, Guid>
    {
    }
}
