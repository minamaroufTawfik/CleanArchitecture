using EventsStar.Domain.Shared.Utility;

namespace EventsStart.Infrastructure
{
    public class MachineDateTime : IDateTime
    {
        public DateTime Now => DateTime.Now;

        public DateOnly DateOnlyNow => DateOnly.FromDateTime(Now);
    }
}
