using CrudCompanyEmployeeApi.Domain.Entities;
using CrudCompanyEmployeeApi.Service.Validations.Base;
using FluentValidation;

namespace CrudCompanyEmployeeApi.Service.Validations.Module
{
    public class EmployeeValidator : BaseValidator<Employee>
    {
        EmployeeValidator()
        {
            RuleFor(x =>x.Name).Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage(MensagemCampoObrigatorio("Nome"))
                .MaximumLength(200).WithMessage(MensagemTamanhoMaximoCampo("Nome", 200));
        }
    }
}
