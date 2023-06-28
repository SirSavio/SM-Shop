using MediatR;
using SMSites.Shop.Core.Application.Services.EventSourcing.SaveEventStored;
using SMSites.Shop.Core.Domain.EventSourcing;

namespace SMSites.Shop.Core.Application.Services.EventSourcing.OnError
{
    internal class OnErrorCommandHandler : IRequestHandler<OnErrorCommand>
    {
        private readonly IMediator _mediator;

        public OnErrorCommandHandler(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task Handle(OnErrorCommand request, CancellationToken cancellationToken)
        {
            var eventStored = EventStored.GetError(request.EntityId, request.JsonCommand, request.CommandTypeOf!, request.CommandType, request.Exception);
            var command = new SaveEventStoredCommand(eventStored);
            await _mediator.Send(command, cancellationToken);
        }
    }
}
