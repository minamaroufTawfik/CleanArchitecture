using EventsStar.Domain.Events;
using EventsStar.Domain.Members;
using EventsStar.Domain.Shared.Utility;

namespace EventsStar.Domain.Attendances
{
    public class AttendanceManager
    {
        private IDateTime DateTime { get; }
        public AttendanceManager(IDateTime dateTime)
        {
            DateTime = dateTime;
        }

        public Attendance AddAttendance(Member member, Event ev, DateTime attendanceDate)
        {
            if (attendanceDate > DateTime.Now)
            {
                throw new Exception("AttendanceDate can not be in the future!");
            }
            return new Attendance(member, ev, attendanceDate);
        }
    }
}
