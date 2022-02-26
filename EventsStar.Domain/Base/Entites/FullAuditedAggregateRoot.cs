namespace EventsStar.Domain.Base.Entites
{
    public abstract class FullAuditedAggregateRoot<TKey> : AuditedAggregateRoot<TKey>
    {
        public virtual bool IsDeleted
        {
            get;
            set;
        }

        protected FullAuditedAggregateRoot()
        {
        }

        protected FullAuditedAggregateRoot(TKey id)
            : base(id)
        {
        }
    }
}
