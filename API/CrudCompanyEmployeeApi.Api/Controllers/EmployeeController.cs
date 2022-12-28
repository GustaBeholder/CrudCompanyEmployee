using CrudCompanyEmployeeApi.Crosscutting.DTO.Employee;
using CrudCompanyEmployeeApi.Service.Modules.Module.Interface;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Net;

namespace CrudCompanyEmployeeApi.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : BaseController
    {
        private readonly IEmployeeApplicationService _employeeApplicationService;

        public EmployeeController(IEmployeeApplicationService employeeApplicationService) => _employeeApplicationService = employeeApplicationService;


        /// <summary>
        /// Busca a lista de todoas as Empresas
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [SwaggerResponse((int)HttpStatusCode.OK, "Listagem de Empregados.", typeof(ICollection<EmployeeGetDTO>))]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, "Ocorreu um erro ao tentar buscar os empregados, verifique a requisição", typeof(string))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, "Ocorreu um erro desconhecido ao tentar buscar as empresas, contate o administrador", typeof(string))]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(_employeeApplicationService.GetAll());
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
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
        [SwaggerResponse((int)HttpStatusCode.OK, "Busca único empregado.", typeof(EmployeeGetDTO))]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, "Ocorreu um erro ao tentar buscar o empregado, verifique a requisição", typeof(string))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, "Ocorreu um erro desconhecido ao tentar buscar o empregado, contate o administrador", typeof(string))]
        public IActionResult GetById([FromRoute] int id)
        {
            try
            {
                return Ok(_employeeApplicationService.GetById(id));
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
        /// <param></param>
        /// <returns></returns>
        [HttpPost]
        [SwaggerResponse((int)HttpStatusCode.OK, "Inserir novo Empregado.", typeof(int))]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, "Ocorreu um erro ao tentar inserir um novo Empregado, verifique a requisição", typeof(string))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, "Ocorreu um erro desconhecido ao tentar inserir uma nova empresa, contate o administrador", typeof(string))]
        public IActionResult Insert([FromBody] EmployeeInsertDTO dto)
        {
            try
            {
                return Ok(_employeeApplicationService.Insert(dto));
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
        public IActionResult Update([FromBody] EmployeeUpdateDTO dto)
        {
            try
            {
                return Ok(_employeeApplicationService.Update(dto));
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
