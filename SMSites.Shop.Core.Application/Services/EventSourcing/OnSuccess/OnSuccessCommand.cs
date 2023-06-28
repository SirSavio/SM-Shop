using MediatR;
using SMSites.Shop.Core.Application.Services.EventSourcing.DTOs;
using SMSites.Shop.Core.Domain.EventSourcing;

namespace SMSites.Shop.Core.Application.Services.EventSourcing.OnSuccess
{
    public class OnSuccessCommand : BaseEventStored, IRequest
    {
        public OnSuccessCommand(object command, EventType commandType) : base(command, commandType)
        {
        }
    }

}
