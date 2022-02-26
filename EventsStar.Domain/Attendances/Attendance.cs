using EventsStar.Domain.Base.Entites;
using EventsStar.Domain.Events;
using EventsStar.Domain.Members;

namespace EventsStar.Domain.Attendances
{
    public class Attendance : FullAuditedAggregateRoot<Guid>
    {
        public Member Member { get; private set; }
        public Event Event { get; private set; }
        public DateTime AttendanceDate { get; private set; }
        public Attendance()
        {
            /* This constructor is for deserialization / ORM purpose */
        }
        public Attendance(Member member, Event ev, DateTime attendanceDate)
        {
            Member = member;
            Event = ev;
            AttendanceDate = attendanceDate;
        }
    }
}
