﻿using MediatR;
using SMSites.Shop.Core.Domain.Services.Bus;

namespace SMSites.Shop.Core.Application.Services.EventSourcing.SaveEventStored
{
    public class SaveEventStoredCommandHandler : IRequestHandler<SaveEventStoredCommand>
    {

        private readonly BusService _busService;

        public SaveEventStoredCommandHandler(BusService busService)
        {
            _busService = busService;
        }

        public async Task Handle(SaveEventStoredCommand request, CancellationToken cancellationToken)
        {
            await _busService.SendMessage(request, cancellationToken, BusTransactionType.Infrastructure);
        }
    }
}
