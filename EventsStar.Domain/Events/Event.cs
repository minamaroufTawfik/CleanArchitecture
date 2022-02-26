using EventsStar.Domain.Base.Entites;
using EventsStar.Domain.Shared.Events;
using EventsStar.Domain.Shared.Extensions;

namespace EventsStar.Domain.Events
{
    public class Event : FullAuditedAggregateRoot<Guid>
    {
        public virtual string Name { get; private set; }
        public virtual string PlaceName { get; private set; }
        public virtual string Desription { get; set; }
        public virtual int Duration { get; private set; }
        public virtual EventDurationType DurationType { get; private set; }

        private Event()
        {
            /* This constructor is for deserialization / ORM purpose */
            Name = string.Empty;
            PlaceName = string.Empty;
            Desription = string.Empty;
        }
        internal Event(Guid id, string name, string placeName, string desription, int duration, EventDurationType durationType) : base(id)
        {
            SetName(name);
            SetPlaceName(placeName);
            SetDuration(duration, durationType);
            Desription = desription;
        }

        internal Event ChangeName(string name)
        {
            SetName(name);
            return this;
        }

        internal Event ChangePlaceName(string placeName)
        {
            SetPlaceName(placeName);
            return this;
        }

        internal Event SetDuration(int duration, EventDurationType durationType)
        {
            Duration = duration;
            DurationType = durationType;
            return this;
        }

        private void SetName(string name)
        {
            Name = Check.NotNullOrWhiteSpace(
               name,
               nameof(name),
               maxLength: EventConsts.MaxNameLength
           );
        }

        private void SetPlaceName(string placeName)
        {
            PlaceName = Check.NotNullOrWhiteSpace(
               placeName,
               nameof(placeName)
           );
        }
    }
}
