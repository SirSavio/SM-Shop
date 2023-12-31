﻿using MediatR;
using SMSites.Shop.Core.Domain.Services.Bus.Interfaces;
using SMSites.Shop.Core.Domain.Services.Bus.Models;

namespace SMSites.Shop.Core.Domain.Services.Bus
{
    public class BusService
    {
        private readonly IMediator _mediator;
        private readonly IInfrastructureBusService _infrastructureBus;

        public BusService(IMediator mediator, IInfrastructureBusService infrastructureBus)
        {
            _mediator = mediator;
            _infrastructureBus = infrastructureBus;
        }

        public async Task PublishEvent<TData>(TData data, CancellationToken cancellationToken = default, BusTransactionType transactionType = BusTransactionType.Memory)
            where TData : IAppEvent
        {
            switch (transactionType)
            {
                case BusTransactionType.Memory:
                    await _mediator.Publish(data!, cancellationToken);
                    break;
                case BusTransactionType.Infrastructure:
                    await _infrastructureBus.PublishEvent(data, cancellationToken);
                    break;
                default:
                    throw new Exception("Invalid transaction type");
            }

        }

        public async Task<CommandResult> SendMessage<TData>(TData data, CancellationToken cancellationToken = default, BusTransactionType transactionType = BusTransactionType.Memory)
            where TData : IAppMessage
        {
            return transactionType switch
            {
                BusTransactionType.Memory => await _mediator.Send(data!, cancellationToken),
                BusTransactionType.Infrastructure => await _infrastructureBus.SendMessage(data, cancellationToken),
                _ => throw new Exception("Invalid transaction type"),
            };
        }
        public async Task<CommandResult<TResponse>> SendMessage<TData, TResponse>(TData data, CancellationToken cancellationToken = default, BusTransactionType transactionType = BusTransactionType.Memory)
            where TData : IAppMessage<TResponse>
        {

            return transactionType switch
            {
                BusTransactionType.Memory => await _mediator.Send(data!, cancellationToken),
                BusTransactionType.Infrastructure => await _infrastructureBus.SendMessage<TData, TResponse>(data, cancellationToken),
                _ => throw new Exception("Invalid transaction type"),
            };
        }
    }
}
