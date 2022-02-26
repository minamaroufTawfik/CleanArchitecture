using EventsStar.Application.Contracts.Attendances;
using EventsStar.Application.Contracts.Common;
using EventsStar.Domain.Attendances;
using EventsStar.Domain.Events;
using EventsStar.Domain.Members;
using EventsStar.Domain.Shared.Utility;

namespace EventsStar.Application.Attendances
{
    public class AttendanceAppService : IAttendanceAppService
    {
        private AttendanceManager AttendanceManager { get; }
        private IMemberRepository MemberRepository { get; }
        private IEventRepository EventRepository { get; }
        private IAttendanceRepository AttendanceRepository { get; }
        private IEventsStarDbContext DbContext { get; }
        private IDateTime DateTime { get;  }
        public AttendanceAppService(AttendanceManager attendanceManager, IAttendanceRepository attendanceRepository,
            IMemberRepository memberRepository, IEventRepository eventRepository,
            IDateTime dateTime, IEventsStarDbContext dbContext)
        {
            AttendanceManager = attendanceManager;
            AttendanceRepository = attendanceRepository;
            MemberRepository = memberRepository;
            EventRepository = eventRepository;
            DateTime = dateTime;
            DbContext = dbContext;
        }

        public async Task AddAttendanceAsync(CreateAttendanceDto attendanceDto)
        {
            Member member = await MemberRepository.GetByIdAsync(attendanceDto.MemberId);
            Event @event = await EventRepository.GetByIdAsync(attendanceDto.EventId);
            Attendance attendance = AttendanceManager.AddAttendance(member, @event, DateTime.Now);
            await AttendanceRepository.AddAsync(attendance);
            await DbContext.SaveChangesAsync();
        }
    }
}
