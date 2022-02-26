
namespace EventsStar.Domain.Base.Entites
{
    public abstract class CreationAuditedAggregateRoot<TKey>: Entity<TKey>
    {
        public virtual DateTime CreatedOn
        {
            get;
            set;
        }
        public virtual Guid? CreatorBy
        {
            get;
            set;
        }

        protected CreationAuditedAggregateRoot()
        {
        }

        protected CreationAuditedAggregateRoot(TKey id)
            : base(id)
        {
        }
    }
}
