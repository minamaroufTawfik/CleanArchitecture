namespace EventsStar.Domain.Base.Entites
{
    public abstract class AuditedAggregateRoot<TKey>: CreationAuditedAggregateRoot<TKey>
    {
        public virtual DateTime? LastModifiedOn { get; set; }

        public virtual Guid? LastModifiedBy { get; set; }

        protected AuditedAggregateRoot()
        {
        }

        protected AuditedAggregateRoot(TKey id)
            : base(id)
        {
        }
    }
}
