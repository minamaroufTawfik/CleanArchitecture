namespace EventsStar.Application.Contracts.Attendances
{
    public interface IAttendanceAppService
    {
        Task AddAttendanceAsync(CreateAttendanceDto attendanceDto);
    }
}
