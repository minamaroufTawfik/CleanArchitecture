using EventsStar.Domain.Shared.Utility;

namespace EventsStar.Domain.Members
{
    public class MemberManager
    {
        private IDateTime DateTime { get; }
        public MemberManager(IDateTime dateTime)
        {
            DateTime = dateTime;
        }

        public Member AddMember(string name, DateOnly birthDate, string job)
        {
            if (birthDate > DateTime.DateOnlyNow)
            {
                throw new Exception("BirthDate can not be in the future!");
            }
            return new Member(name, birthDate, job);
        }

    }
}
