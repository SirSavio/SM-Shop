using MediatR;
using SMSites.Shop.Core.Domain.Services.Bus.Models;

namespace SMSites.Shop.Core.Domain.Services.Bus.Interfaces
{
    public interface IAppMessage : IRequest<CommandResult>
    {
    }

    public interface IAppMessage<TResponse> : IRequest<CommandResult<TResponse>>
    {
    }
}
