using MediatR;
using SMSites.Shop.Core.Application.In.Commands.AddEntity;
using SMSites.Shop.Core.Domain.EventSourcing;
using SMSites.Shop.Core.Domain.Services.Bus.Models;

namespace SMSites.Shop.Core.Application.Tests.FakeCommandHandlers.FakeCreateEntity
{
    internal class FakeCreateEntityCommandHandler : AddEntityCommandHandler<FakeEntity, IFakeEntityRepository, FakeCreateEntityCommand>
    {
        public FakeCreateEntityCommandHandler(IMediator mediator) : base(mediator)
        {
        }

        public override Task<CommandResult<Guid>> ExecuteAsync(FakeCreateEntityCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(CommandResult<Guid>.GetSuccess(Guid.Empty));
        }

        protected override EventType GetEventType() => EventType.Create;
    }
}
