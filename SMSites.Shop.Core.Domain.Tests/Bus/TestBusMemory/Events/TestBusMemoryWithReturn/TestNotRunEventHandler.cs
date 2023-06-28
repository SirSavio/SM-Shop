using MediatR;
using SMSites.Shop.Core.Domain.Services.DomainNotifications;

namespace SMSites.Shop.Core.Domain.Tests.Bus.TestBusMemory.Events.TestBusMemoryWithReturn
{
    internal class TestNotRunEventHandler : INotificationHandler<TestNotRunEvent>
    {
        private readonly DomainNotificationService _domainNotificationService;

        public Task Handle(TestNotRunEvent notification, CancellationToken cancellationToken)
        {
            _domainNotificationService.Add("error", "the handler shouldn't run");
            return Task.CompletedTask;
        }
    }
}
