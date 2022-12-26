using FluentValidation;

namespace CrudCompanyEmployeeApi.Service.Validations.Base
{
    public class BaseValidator<T> : AbstractValidator<T>
    {
        protected string MensagemCampoObrigatorio(string campo) => $"O campo {campo} é obrigatório.";
        protected string MensagemCampoInvalido(string campo) => $"O valor para o campo {campo} é inválido.";
        protected string MensagemTamanhoMaximoCampo(string campo, int tamanho) => $"O campo {campo} deve conter no máximo {tamanho} caracteres";
        protected string MensagemTamanhoMinimoCampo(string campo, int tamanho) => $"O campo {campo} deve conter no mínimo {tamanho} caracteres";
        protected string MensagemTamanhoCampo(string campo, int tamanho) => $"O campo {campo} deve conter {tamanho} caracteres";
        protected string MensagemPrecisaoDecimal(string campo, int casasDecimais) => $"O campo {campo} deve conter precisão de {casasDecimais} casas decimais";
        protected string MensagemValorMinMax<N>(string campo, N min, N max) => $"O campo {campo} deve conter um valor entre {min} e {max}";
    }
}
