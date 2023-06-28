using SMSites.Shop.Core.Domain.DTOs.Entities;
using SMSites.Shop.Core.Domain.Services.Bus.Interfaces;

namespace SMSites.Shop.Core.Application.Tests.FakeCommandHandlers.FakeCreateEntity
{
    internal class FakeCreateEntityCommand : NamedEntityDTO, IAppMessage<Guid>
    {
        public FakeCreateEntityCommand()
        {
        }
    }
}
