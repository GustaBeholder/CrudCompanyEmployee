using CrudCompanyEmployeeApi.Domain.Entities;
using CrudCompanyEmployeeApi.Service.Validations.Base;
using FluentValidation;

namespace CrudCompanyEmployeeApi.Service.Validations.Module
{
    public class CompanyValidator : BaseValidator<Company>
    {
        public CompanyValidator()
        {
            RuleFor(x => x.Name).Cascade(CascadeMode.Stop)
                  .NotEmpty().WithMessage(MensagemCampoObrigatorio("Nome"))
                  .MaximumLength(200).WithMessage(MensagemTamanhoMaximoCampo("Nome", 200));
            RuleFor(x => x.Phone).Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage(MensagemCampoObrigatorio("Telefone"));
        }
    }
}
