using SMSites.Shop.Core.Domain.Interfaces.Entities;

namespace SMSites.Shop.Core.Domain.Interfaces.Repositories
{
    public interface IWriterRepository<TEntity> where TEntity : IEntity
    {
        Task<TEntity> AddAsync(TEntity entity, CancellationToken cancellationToken = default);
        Task<TEntity> UpdateAsync(TEntity entity, CancellationToken cancellationToken = default);
        Task DeleteAsync(TEntity entity, CancellationToken cancellationToken = default);
    }
}
