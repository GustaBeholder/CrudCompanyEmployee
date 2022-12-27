
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
            return _context.Set<TEntity>().ToList();
        }

        public virtual TEntity GetById(int id)
        {
            return _context.Set<TEntity>().Find(new object[] { id })!;
        }

        public virtual void Insert(TEntity entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
            
        }

        public virtual void Update(TEntity entity)
        {
            _context.Update(entity);
            _context.SaveChanges();
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
