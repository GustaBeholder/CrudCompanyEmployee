using CrudCompanyEmployeeApi.Crosscutting.DTO;
using CrudCompanyEmployeeApi.Service.Modules.Module.Interface;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Net;

namespace CrudCompanyEmployeeApi.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CompanyController : BaseController
    {
        private readonly ICompanyApplicationService _companyApplicationService;

        public CompanyController (ICompanyApplicationService companyApplicationService) => _companyApplicationService = companyApplicationService;
  

        /// <summary>
        /// Busca a lista de todoas as Empresas
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [SwaggerResponse((int)HttpStatusCode.OK, "Listagem de Empresas.", typeof(ICollection<CompanyGetDTO>))]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, "Ocorreu um erro ao tentar buscar as empresas, verifique a requisição", typeof(string))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, "Ocorreu um erro desconhecido ao tentar buscar as empresas, contate o administrador", typeof(string))]
        public IActionResult GetAll()
        {
            try
            {
                return Ok (_companyApplicationService.GetAll());
            }
            catch(ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch(Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        /// <summary>
        /// Busca uma Empresa pelo número do Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        [SwaggerResponse((int)HttpStatusCode.OK, "Busca único Evento.", typeof(CompanyGetDTO))]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, "Ocorreu um erro ao tentar buscar a empresa, verifique a requisição", typeof(string))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, "Ocorreu um erro desconhecido ao tentar buscar a empresa, contate o administrador", typeof(string))]
        public IActionResult GetById([FromRoute] int id)
        {
            try
            {
                return Ok(_companyApplicationService.GetById(id));
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }

        }
        /// <summary>
        /// Insere um novo Evento
        /// </summary>
        /// <param name="dto"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        [HttpPost]
        [SwaggerResponse((int)HttpStatusCode.OK, "Inserir novo Evento.", typeof(int))]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, "Ocorreu um erro ao tentar inserir uma nova empresa, verifique a requisição", typeof(string))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, "Ocorreu um erro desconhecido ao tentar inserir uma nova empresa, contate o administrador", typeof(string))]
        public  IActionResult Insert([FromBody] CompanyInsertDTO dto)
        {
            try
            {
                return Ok(_companyApplicationService.Insert(dto));
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        /// <summary>
        /// Atualiza uma Empresa
        /// </summary>
        /// <param></param>
        /// <param></param>
        /// <returns></returns>
        [HttpPut]
        [SwaggerResponse((int)HttpStatusCode.OK, "Atualizar dados Empresa.", typeof(int))]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, "Ocorreu um erro ao tentar Atualizar empresa, verifique a requisição", typeof(string))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, "Ocorreu um erro desconhecido ao tentar Atualizar uma  empresa, contate o administrador", typeof(string))]
        public IActionResult Update([FromBody] CompanyUpdateDTO dto)
        {
            try
            {
                return Ok(_companyApplicationService.Update(dto));
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

    }
}
