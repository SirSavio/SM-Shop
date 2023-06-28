using MediatR;
using SMSites.Shop.Core.Application.In.Commands.Bases;
using SMSites.Shop.Core.Domain.EventSourcing;
using SMSites.Shop.Core.Domain.Services.Bus.Models;
using SMSites.Shop.Core.Domain.Services.DomainNotifications;

namespace SMSites.Shop.Core.Domain.Tests.Bus.TestBusMemory.Commands.TestBusMemoryWithoutReturn
{
    internal class TestBusMemoryWithoutReturnCommandHandler : BaseRequestHandler<TestBusMemoryWithoutReturnCommand>
    {
        private readonly DomainNotificationService _domainNotificationService;

        public TestBusMemoryWithoutReturnCommandHandler(IMediator mediator, DomainNotificationService domainNotificationService) : base(mediator)
        {
            _domainNotificationService = domainNotificationService;
        }

        public override Task<CommandResult> ExecuteAsync(TestBusMemoryWithoutReturnCommand request, CancellationToken cancellationToken)
        {
            _domainNotificationService.Add("test", "the first message has proccess");
            if (request.ThrowError)
                throw new Exception("Expected Error");

            return Task.FromResult(CommandResult.GetSuccess());
        }

        protected override EventType GetEventType()
        {
            return EventType.Create;
        }

    }
}
