using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace CrudCompanyEmployeeApi.Api.Controllers
{
    public abstract class BaseController : ControllerBase
    {
        protected IActionResult BadRequest(Exception ex) =>
            StatusCode((int)HttpStatusCode.BadRequest, ex.Message);

        protected IActionResult InternalServerError(Exception ex) =>
            StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
    }
}
