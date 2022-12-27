using CrudCompanyEmployeeApi.Infrastructure.Data;
using CrudCompanyEmployeeApi.Infrastructure.UnitOfWork.Interface;

namespace CrudCompanyEmployeeApi.Infrastructure.UnitOfWork
{
    public class GenericUnitOfWork : IGenericUnitOfWork
    {
        private readonly ApplicationContext _session;
        protected readonly IServiceProvider _serviceProvider;

        public GenericUnitOfWork(ApplicationContext session, IServiceProvider serviceProvider)
        {
            _session = session;
            _serviceProvider = serviceProvider;
        }

        public void BeginTransaction()
        {
            throw new NotImplementedException();
        }

        public void Commit()
        {
            throw new NotImplementedException();
        }

        public void Rollback()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _session.Dispose();
        }
    }
}
