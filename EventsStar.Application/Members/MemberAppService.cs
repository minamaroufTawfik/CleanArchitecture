using EventsStar.Application.Contracts.Common;
using EventsStar.Application.Contracts.Members;
using EventsStar.Domain.Members;

namespace EventsStar.Application.Members
{
    public class MemberAppService : IMemberAppService
    {
        private MemberManager MemberManager { get; }
        private IMemberRepository MemberRepository { get; }
        private IEventsStarDbContext DbContext { get; }
        public MemberAppService(MemberManager memberManager, IMemberRepository memberRepository,
            IEventsStarDbContext dbContext)
        {
            MemberManager = memberManager;
            MemberRepository = memberRepository;
            DbContext = dbContext;
        }
        public async Task AddMember(CreateMemberDto memberDto)
        {
            Member member = MemberManager.AddMember(memberDto.Name, memberDto.BirthDate, memberDto.Job);
            await MemberRepository.AddAsync(member);
            await DbContext.SaveChangesAsync();
        }
    }
}
