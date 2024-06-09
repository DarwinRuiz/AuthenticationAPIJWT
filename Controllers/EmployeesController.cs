using AuthenticationAPIJWT.Data;
using AuthenticationAPIJWT.Dtos.Shared;
using AuthenticationAPIJWT.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AuthenticationAPIJWT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {

        [HttpGet]
        [Authorize(Roles = ("Administrador"))]
        public IActionResult Get()
        {
            List<Employee> listEmployee = DBContext.Employees;

            return Ok(new HttpResponseDTO<Employee>(200, "Request Success", listEmployee));
        }
    }
}
