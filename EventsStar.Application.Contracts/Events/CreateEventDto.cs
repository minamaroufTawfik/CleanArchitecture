using EventsStar.Domain.Shared.Events;
using System.ComponentModel.DataAnnotations;

namespace EventsStar.Application.Contracts.Events
{
    public class CreateEventDto
    {
        [Required]
        [StringLength(EventConsts.MaxNameLength)]
        public string Name { get; set; }

        [Required]
        public string PlaceName { get; set; }
        public string Desription { get; set; }
        public int Duration { get; set; }
        public EventDurationType DurationType { get; set; }
    }
}
