using MediatR;
using SMSites.Shop.Core.Application.In.Commands.Bases;
using SMSites.Shop.Core.Domain.EventSourcing;
using SMSites.Shop.Core.Domain.Interfaces.DTOs;
using SMSites.Shop.Core.Domain.Interfaces.Entities;
using SMSites.Shop.Core.Domain.Interfaces.Repositories;
using SMSites.Shop.Core.Domain.Services.Bus.Interfaces;
using SMSites.Shop.Core.Domain.Services.Bus.Models;

namespace SMSites.Shop.Core.Application.In.Commands.AddEntity
{
    public class AddEntityCommandHandler<TEntity, TRepository, TAddCommand> : BaseRequesHandler<TAddCommand, Guid>
        where TEntity : IEntity
        where TRepository : IWriterRepository<TEntity>
        where TAddCommand : IEntityDTO, IAppMessage<Guid>

    {

        public AddEntityCommandHandler(IMediator mediator) : base(mediator)
        {
        }

        public override Task<CommandResult<Guid>> ExecuteAsync(TAddCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        protected override EventType GetEventType()
        {
            throw new NotImplementedException();
        }
    }
}
