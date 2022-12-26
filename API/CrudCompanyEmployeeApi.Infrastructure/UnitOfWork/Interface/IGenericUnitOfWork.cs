

namespace CrudCompanyEmployeeApi.Infrastructure.UnitOfWork.Interface
{
    public interface IGenericUnitOfWork : IDisposable
    {
        void BeginTransaction();
        void Commit();
        void Rollback();
    }
}
