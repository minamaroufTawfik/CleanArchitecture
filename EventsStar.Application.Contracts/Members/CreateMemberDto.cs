using System.ComponentModel.DataAnnotations;

namespace EventsStar.Application.Contracts.Members
{
    public class CreateMemberDto
    {
        [Required]
        public string Name { get; set; }
        
        [Required]
        public DateOnly BirthDate { get; internal set; }
        public string Job { get; set; }
    }
}
