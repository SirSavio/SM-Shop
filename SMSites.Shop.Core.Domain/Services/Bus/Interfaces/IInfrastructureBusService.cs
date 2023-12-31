﻿using SMSites.Shop.Core.Domain.Services.Bus.Models;

namespace SMSites.Shop.Core.Domain.Services.Bus.Interfaces
{
    public interface IInfrastructureBusService
    {
        Task PublishEvent<TData>(TData data, CancellationToken cancellationToken = default);
        Task<CommandResult> SendMessage<TData>(TData data, CancellationToken cancellationToken = default);
        Task<CommandResult<TResponse>> SendMessage<TData, TResponse>(TData data, CancellationToken cancellationToken = default);
    }
}
