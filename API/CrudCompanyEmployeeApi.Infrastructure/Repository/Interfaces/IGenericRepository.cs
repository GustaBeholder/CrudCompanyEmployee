

namespace CrudCompanyEmployeeApi.Infrastructure.Repository.Interfaces
{
    public interface IGenericRepository<TEntity>
    {
        #region Sync Methods

        IEnumerable<TEntity> GetAll();
        TEntity GetById(int id);
        void Insert(TEntity entity);
        void Update(TEntity entity);

        #endregion

        #region Async Methods

        Task<IEnumerable<TEntity>> GetAllAsync(CancellationToken ct = default);
        Task<TEntity> GetByIdAsync(int id, CancellationToken ct = default);
        Task<TEntity> GetByIdAsync(long id, CancellationToken ct = default);
        Task<int> InsertAsync(TEntity entity, CancellationToken ct = default);
        Task DeleteAsync(TEntity entity, CancellationToken ct = default);
        Task UpdateAsync(TEntity entity, CancellationToken ct = default);

        #endregion
    }
}
