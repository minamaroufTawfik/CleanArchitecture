using EventsStar.Domain.Base.Entites;

namespace EventsStar.Domain.Members
{
    public class Member : FullAuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }
        public DateOnly BirthDate { get; internal set; }
        public string Job { get; set; }

        public Member()
        {
            /* This constructor is for deserialization / ORM purpose */
            Name = string.Empty;
            Job = string.Empty;
        }

        public Member(string name, DateOnly birthDate, string job)
        {
            Name = name;
            BirthDate = birthDate;
            Job = job;
        }

    }
}
