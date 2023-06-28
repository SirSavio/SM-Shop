using MediatR;
using SMSites.Shop.Core.Application.Services.EventSourcing.OnError;
using SMSites.Shop.Core.Application.Services.EventSourcing.OnSuccess;
using SMSites.Shop.Core.Domain.EventSourcing;
using SMSites.Shop.Core.Domain.Interfaces.DTOs;
using SMSites.Shop.Core.Domain.Services.Bus.Models;

namespace SMSites.Shop.Core.Application.In.Commands.Bases
{
    public abstract class BaseRequestHandler<TRequest> : IRequestHandler<TRequest, CommandResult>
        where TRequest : IRequest<CommandResult>
    {
        private readonly IMediator _mediator;
        protected BaseRequestHandler(IMediator mediator)
        {
            _mediator = mediator;
        }
        public async Task<CommandResult> Handle(TRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var result = await ExecuteAsync(request, cancellationToken);
                await _mediator.Send(new OnSuccessCommand(request, GetEventType()), cancellationToken);
                return result;
            }
            catch (Exception error)
            {
                await _mediator.Send(new OnErrorCommand(request, GetEventType(), error), cancellationToken);
                throw new Exception("Error on execute command", error);
            }
        }

        public abstract Task<CommandResult> ExecuteAsync(TRequest request, CancellationToken cancellationToken);
        protected abstract EventType GetEventType();
    }

    public abstract class BaseRequesHandler<TRequest, TResponse> :
        IRequestHandler<TRequest, CommandResult<TResponse>>

        where TRequest : IRequest<CommandResult<TResponse>>, IEntityDTO
    {
        private readonly IMediator _mediator;

        protected BaseRequesHandler(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<CommandResult<TResponse>> Handle(TRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var result = await ExecuteAsync(request, cancellationToken);
                await _mediator.Send(new OnSuccessCommand(request, GetEventType()), cancellationToken);
                return result;
            }
            catch (Exception error)
            {
                await _mediator.Send(new OnErrorCommand(request, GetEventType(), error), cancellationToken);
                throw new Exception("Error on execute command", error);
            }
        }
        public abstract Task<CommandResult<TResponse>> ExecuteAsync(TRequest request, CancellationToken cancellationToken);
        protected abstract EventType GetEventType();
    }
}
