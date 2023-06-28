using MediatR;
using SMSites.Shop.Core.Domain.EventSourcing;
using SMSites.Shop.Core.Domain.Services.Bus.Interfaces;

namespace SMSites.Shop.Core.Application.Services.EventSourcing.SaveEventStored
{
    public class SaveEventStoredCommand : IAppMessage, IRequest
    {

        public SaveEventStoredCommand(EventStored eventStored)
        {
            EventStored = eventStored;
        }

        public EventStored EventStored { get; private set; }
    }
}
