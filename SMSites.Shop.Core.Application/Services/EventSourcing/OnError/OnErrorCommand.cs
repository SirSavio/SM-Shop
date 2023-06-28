using MediatR;
using SMSites.Shop.Core.Application.Services.EventSourcing.DTOs;
using SMSites.Shop.Core.Domain.EventSourcing;

namespace SMSites.Shop.Core.Application.Services.EventSourcing.OnError
{
    public class OnErrorCommand : BaseEventStored, IRequest
    {
        public OnErrorCommand(object command, EventType commandType, Exception exception) : base(command, commandType)
        {
            Exception = exception;
        }


        public Exception Exception { get; private set; }
    }
}
