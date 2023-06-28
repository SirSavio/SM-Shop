using SMSites.Shop.Core.Domain.Interfaces.Entities;

namespace SMSites.Shop.Core.Domain.Interfaces.Repositories
{
    public interface IReaderRepository<TEntity> where TEntity : IEntity
    {
        Task<TEntity> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
        Task<IEnumerable<TEntity>> GetAllAsync(CancellationToken cancellationToken = default);
        Task<IEnumerable<TEntity>> GetBySearchKeyAsync(string searchKey, CancellationToken cancellationToken = default);

    }
}
