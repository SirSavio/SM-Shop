using MediatR;
using SMSites.Shop.Core.Application.In.Commands.Bases;
using SMSites.Shop.Core.Domain.EventSourcing;
using SMSites.Shop.Core.Domain.Services.Bus.Models;
using SMSites.Shop.Core.Domain.Services.DomainNotifications;

namespace SMSites.Shop.Core.Domain.Tests.Bus.TestBusMemory.Commands.TestBusMemoryWithReturn
{
    internal class TestBusMemoryWithReturnCommandHandler : BaseRequesHandler<TestBusMemoryWithReturnCommand, Guid>
    {
        private readonly DomainNotificationService _domainNotificationService;

        public TestBusMemoryWithReturnCommandHandler(IMediator mediator, DomainNotificationService domainNotificationService) : base(mediator)
        {
            _domainNotificationService = domainNotificationService;
        }


        public override Task<CommandResult<Guid>> ExecuteAsync(TestBusMemoryWithReturnCommand request, CancellationToken cancellationToken)
        {
            _domainNotificationService.Add("test", "the first message has proccess");
            return Task.FromResult(CommandResult<Guid>.GetSuccess(Guid.NewGuid()));
        }

        protected override EventType GetEventType()
        {
            return EventType.Create;
        }
    }
}
