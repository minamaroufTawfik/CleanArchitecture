namespace EventsStar.Application.Contracts.Members
{
    public interface IMemberAppService
    {
        Task AddMember(CreateMemberDto memberDto);
    }
}
