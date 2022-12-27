using CrudCompanyEmployeeApi.Infrastructure.Repository.Interfaces;
using CrudCompanyEmployeeApi.Infrastructure.UnitOfWork.Interface;
using CrudCompanyEmployeeApi.Service.Validations.Base;

namespace CrudCompanyEmployeeApi.Service.Modules.Base
{
    public class BaseApplicationService<TUnitOfWork, TRepository, TEntity>
        where TUnitOfWork : IGenericUnitOfWork
        where TRepository : IGenericRepository<TEntity>
        where TEntity : class
    {
        protected TUnitOfWork _uow;
        private IGenericRepository<TEntity> Repository
        {
            get
            {
                var property = _uow.GetType().GetProperty(typeof(TRepository).Name[1..]);
                return property?.GetValue(_uow) as IGenericRepository<TEntity> ?? throw new Exception($"Repositório da entidade {nameof(TEntity)} não encontrado");
            }
        }

        protected BaseApplicationService(TUnitOfWork uow)
        {
            _uow = uow;
        }

        protected async Task Validate(TEntity entidade, BaseValidator<TEntity> validator)
        {
            var validacaoEntidade = await validator.ValidateAsync(entidade);
            if (!validacaoEntidade.IsValid)
                throw new ArgumentException(validacaoEntidade?.Errors?.FirstOrDefault()?.ErrorMessage);
        }
    }
}
