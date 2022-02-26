namespace EventsStar.Domain.Base.Entites
{
    public abstract class Entity<TKey>
    {
        public virtual TKey Id
        {
            get;
            protected set;
        }

        protected Entity()
        {
        }

        protected Entity(TKey id)
        {
            Id = id;
        }
    }
}
