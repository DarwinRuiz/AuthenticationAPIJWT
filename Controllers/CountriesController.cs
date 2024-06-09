using AuthenticationAPIJWT.Data;
using AuthenticationAPIJWT.Dtos.Shared;
using AuthenticationAPIJWT.Models;
using Microsoft.AspNetCore.Mvc;

namespace CAuthenticationAPIJWT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {

        [HttpGet]
        public IActionResult Get()
        {
            List<Country> listCountry = DBContext.Countries;

            return Ok(new HttpResponseDTO<Country>(200, "Request Success", listCountry) );
        }
    }
}
