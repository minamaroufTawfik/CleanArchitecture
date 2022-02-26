using System.ComponentModel.DataAnnotations;

namespace EventsStar.Application.Contracts.Attendances
{
    public class CreateAttendanceDto
    {
        [Required]
        public Guid MemberId { get; set; }

        [Required]
        public Guid EventId { get; set; }
    }
}
