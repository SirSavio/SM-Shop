using SMSites.Shop.Core.Domain.Interfaces.Repositories;

namespace SMSites.Shop.Core.Application.Tests.FakeCommandHandlers.FakeCreateEntity
{
    public interface IFakeEntityRepository : IWriterRepository<FakeEntity>
    {
    }
}
