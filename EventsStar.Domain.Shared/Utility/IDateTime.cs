namespace EventsStar.Domain.Shared.Utility
{
    public interface IDateTime
    {
        DateTime Now { get; }
        DateOnly DateOnlyNow { get; }
    }
}
