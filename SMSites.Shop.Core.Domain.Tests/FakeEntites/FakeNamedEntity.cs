using SMSites.Shop.Core.Domain.Entities;

namespace SMSites.Shop.Core.Domain.Tests.FakeEntites
{
    internal class FakeNamedEntity : NamedEntity
    {
        public FakeNamedEntity(Guid id, string name) : base(id, name)
        {
        }
    }
}
