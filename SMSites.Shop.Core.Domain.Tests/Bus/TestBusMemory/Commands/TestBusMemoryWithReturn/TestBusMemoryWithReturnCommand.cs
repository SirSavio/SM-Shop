using SMSites.Shop.Core.Domain.Interfaces.DTOs;
using SMSites.Shop.Core.Domain.Services.Bus.Interfaces;

namespace SMSites.Shop.Core.Domain.Tests.Bus.TestBusMemory.Commands.TestBusMemoryWithReturn
{
    public class TestBusMemoryWithReturnCommand : IAppMessage<Guid>, IEntityDTO
    {
        public Guid Id { get; set; }
    }
}
