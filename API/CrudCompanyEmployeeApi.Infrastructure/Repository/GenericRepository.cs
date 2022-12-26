
using CrudCompanyEmployeeApi.Infrastructure.Data;
using CrudCompanyEmployeeApi.Infrastructure.Repository.Interfaces;

namespace CrudCompanyEmployeeApi.Infrastructure.Repository
{
    public abstract class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        protected readonly ApplicationContext _context;

        public GenericRepository(ApplicationContext context)
        {
            _context = context;
        }

        #region Sync Methods
        public virtual IEnumerable<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public virtual TEntity GetById(int id)
        {
            throw new NotImplementedException();
        }

        public virtual void Insert(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public virtual void Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public virtual void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Async Methods
        public virtual Task<IEnumerable<TEntity>> GetAllAsync(CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public virtual Task<TEntity> GetByIdAsync(int id, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public virtual Task<TEntity> GetByIdAsync(long id, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public virtual Task<int> InsertAsync(TEntity entity, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public virtual Task DeleteAsync(TEntity entity, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public virtual Task UpdateAsync(TEntity entity, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
