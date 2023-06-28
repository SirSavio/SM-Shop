using SMSites.Shop.Core.Domain.ValueObject;

namespace SMSites.Shop.Core.Domain.Entities
{
    public abstract class NamedEntity : Entity
    {
        protected NamedEntity(Guid id, string name) : base(id)
        {
            Name = new NameVO(name);
        }

        public NameVO Name { get; private set; }
    }
}
