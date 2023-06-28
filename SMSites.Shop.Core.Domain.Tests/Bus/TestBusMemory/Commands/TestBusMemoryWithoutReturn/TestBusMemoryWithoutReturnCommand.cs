using SMSites.Shop.Core.Domain.Interfaces.DTOs;
using SMSites.Shop.Core.Domain.Services.Bus.Interfaces;

namespace SMSites.Shop.Core.Domain.Tests.Bus.TestBusMemory.Commands.TestBusMemoryWithoutReturn
{
    internal class TestBusMemoryWithoutReturnCommand : IAppMessage, IEntityDTO
    {
        public Guid Id { get; set; }
        public bool ThrowError { get; set; }
    }
}
